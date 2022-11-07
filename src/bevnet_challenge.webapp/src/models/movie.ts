export type PaginatedMovies = {
  page: number | 0;
  per_page: number | 0;
  total: number | 0;
  total_pages: number | 0;
  data: Movie[] | [];
};

export type Movie = {
  id: string | null;
  title: string | null;
  year: string | null;
};
