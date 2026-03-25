import axios from "axios";

const API = axios.create({
  baseURL: "https://localhost:7172/api" // adjust port if needed
});

export default API;