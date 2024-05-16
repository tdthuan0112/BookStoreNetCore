import axios from "axios";
import https from "https";

export const API = axios.create({
  baseURL: process.env.NEXT_PUBLIC_API_BASE_URL,
  httpsAgent: new https.Agent({
    rejectUnauthorized: false,
  }),
});
