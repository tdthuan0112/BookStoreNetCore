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
    config = { ...config, next: { revalidate: 3600 } };
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

  post(endpoint = "", payload = {}) {
    const url = this.buildQuery(endpoint);
    return _fetch(
      url,
      { method: "POST", headers: this.#config.headers },
      payload
    );
  }

  async _fetch(url, config, payload) {
    console.log(url);
    console.log(config);

    const result = await fetch(url, {
      ...config,
    })
      .then((response) => {
        //TODO HANDLE ERROR
        //...........

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
