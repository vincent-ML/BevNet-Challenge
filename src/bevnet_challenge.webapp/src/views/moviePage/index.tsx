import { useEffect, useState } from "react";
import ReactPaginate from "react-paginate";
import Moviecard from "../../components/movieCard";
import Search from "../../components/search";
import { Movie, PaginatedMovies } from "../../models/movie";
import { getMovies, getMoviesByTitle } from "../../services/movieService";
import MoviePageStyle from "./style";

export default function MoviePage() {
  const [title, setTitle] = useState<string>("");
  const [pageNumber, setPageNumber] = useState<number>(1);
  const [moviesResult, setMoviesResults] = useState<PaginatedMovies>({
    data: [],
    page: 0,
    per_page: 0,
    total: 0,
    total_pages: 0,
  });

  useEffect(() => {
    getMovies(pageNumber).then((data) => {
      setMoviesResults(data);
    });
  }, []);

  const searchHandler = (title: string) => {
    setPageNumber(1);
    setTitle(title);
    getMoviesByTitle(title, 1).then((data) => {
      console.log(data);
      setMoviesResults(data);
    });
  };

  const handlePageClick = (currentPage: { selected: number }) => {
    const nextPage = ++currentPage.selected;
    setPageNumber(nextPage);
    getMoviesByTitle(title, nextPage).then((data) => {
      setMoviesResults(data);
    });
  };

  return (
    <MoviePageStyle>
      <h1 className='movie-page__title'>BevNet Challenge</h1>
      <Search searchHandler={searchHandler} />
      <div className='movieCard-grid'>
        {moviesResult.data.map((movie: Movie) => (
          <Moviecard {...movie} key={movie.id} />
        ))}
      </div>
      <ReactPaginate
        className='pagination'
        nextClassName='pagination__next'
        previousClassName='pagination__previous'
        breakLabel='...'
        previousLabel='<'
        nextLabel='>'
        onPageChange={handlePageClick}
        pageRangeDisplayed={2}
        pageCount={moviesResult.total_pages}
        forcePage={moviesResult.page - 1}
      />
    </MoviePageStyle>
  );
}
