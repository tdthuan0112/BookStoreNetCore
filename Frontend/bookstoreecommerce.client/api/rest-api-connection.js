const IS_PRODUCTION = process.env.NODE_ENV === "production";

const intitConfig = () => {
  let config = {
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
    cache: IS_PRODUCTION === "production" ? "force-cache" : "no-store",
  };

  if (IS_PRODUCTION) {
    config = { ...config, next: { revalidate: 3600 } }; //In seconds
  }

  return config;
};
class RestApiConnection {
  #config;
  #baseApiUrl;
  #subPath;
  constructor(subPath) {
    this.#baseApiUrl = process.env.NEXT_PUBLIC_API_BASE_URL;
    this.#subPath = subPath;
    this.#config = intitConfig();
  }

  buildQuery(endpoint) {
    return `${this.#baseApiUrl}/${this.#subPath}/${endpoint}`;
  }

  async get(endpoint = "", payload = {}) {
    const url = this.buildQuery(endpoint);
    return await this._fetch(url, { method: "GET", ...this.#config }, payload);
  }

  async post(endpoint = "", payload) {
    const url = this.buildQuery(endpoint);
    return await this._fetch(url, {
      method: "POST",
      body: JSON.stringify(payload),
      ...this.#config,
    });
  }

  async delete(endpoint = "", payload) {
    const url = this.buildQuery(endpoint);
    return await this._fetch(url, {
      method: "DELETE",
      body: JSON.stringify(payload),
      ...this.#config,
    });
  }

  async _fetch(url, config, payload) {
    console.log(url);
    // console.log(config);
    // console.log(payload);

    const result = await fetch(url, config)
      .then((response) => {
        //TODO HANDLE ERROR
        //if(response.code !== 200)
        //THINKING...........

        return response.json();
      })
      .then((result) => {
        //TODO HANDLE DATA (OPTIONAL)
        //THINKING.......

        return result.data;
      });
    return result;
  }
}

export default RestApiConnection;
