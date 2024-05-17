import https from "https";

class RestApiConnection {
  #config;
  #baseApiUrl;
  #subPath;
  constructor(subPath) {
    this.#baseApiUrl = process.env.NEXT_PUBLIC_API_BASE_URL;
    this.#subPath = subPath;
    this.#config = {
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
      },
    };
  }

  buildQuery(endpoint) {
    return `${this.#baseApiUrl}/${this.#subPath}/${endpoint}`;
  }

  get(endpoint = "", payload = {}) {
    const url = this.buildQuery(endpoint);
    return this._fetch(
      url,
      { method: "GET", headers: this.#config.headers },
      payload
    );
  }

  post(endpoint = "", payload = {}) {
    const url = this.buildQuery(endpoint);
    return _fetch(
      url,
      { method: "POST", headers: this.#config.headers },
      payload
    );
  }

  _fetch(url, config, payload) {
    console.log(url);
    console.log(config);

    const httpsAgent = new https.Agent({
      rejectUnauthorized: false,
    });

    fetch(url, {
      method: config.method,
      headers: config.headers,
    })
      .then((response) => {
        return response.json();
      })
      .then((result) => {
        console.log(result);
      });
  }
}

export default RestApiConnection;
