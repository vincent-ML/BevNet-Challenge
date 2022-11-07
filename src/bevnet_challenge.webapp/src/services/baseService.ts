import axios from "axios";
import Alert from "../utils/alert";

var api = axios.create({
  baseURL: `${process.env.REACT_APP_API_URL}/api`,
});

api.interceptors.response.use(
  function (response) {
    return response.data;
  },
  function (error) {
    if (error.message === "Network Error") {
      Alert.error("Error", "Error en la conexion");
      return;
    }

    Alert.error("Error", error.response.data.message);
    return Promise.reject(error.response.data);
  }
);

export default api;