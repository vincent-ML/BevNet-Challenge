import { PaginatedMovies } from "../models/movie";
import api from "./baseService";

const baseUrl = "Movies/";

export const getMovies = async (
  pageNumber: number
): Promise<PaginatedMovies> => {
  const response = await api.get(`${baseUrl}?PageNumber=${pageNumber}`);
  return response as unknown as PaginatedMovies;
};

export const getMoviesByTitle = async (
  title: string,
  pageNumber: number
): Promise<PaginatedMovies> => {
  const response = await api.get(`${baseUrl}${title}?PageNumber=${pageNumber}`);
  return response as unknown as PaginatedMovies;
};
