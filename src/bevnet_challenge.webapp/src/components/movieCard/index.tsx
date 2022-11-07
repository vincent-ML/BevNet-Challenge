import { Movie } from "../../models/movie";
import MovieCardStyle from "./style";
import popcorn from "../../assets/img/popcorn.jpg";

const Moviecard = (movie: Movie) => {
  return (
    <MovieCardStyle>
      <img src={popcorn} alt='placeholder popcorn' />
      <div className="text">
        <p className='movie__year'>{movie.year}</p>
        <p className='movie__title'>{movie.title}</p>
      </div>
    </MovieCardStyle>
  );
};

export default Moviecard;
