import styled from "styled-components";

const MovieCardStyle = styled.span`
  background-color: ${(p) => p.theme.colors.darkGray};
  font-family: ${(p) => p.theme.typography.sansSerif};
  font-weight: 400;
  border-radius: 1rem;

  img {
    width: 100%;
    background-size: cover;
    border-radius: 1rem 1rem 0 0;
    filter: blur(0.5px);
    -webkit-filter: blur(0.5px);
  }

  .text {
    padding: 2rem;
  }

  .movie__year {
    color: ${(p) => p.theme.colors.lightGray};
    font-size: 1.5rem;
    margin: 0;
  }

  .movie__title {
    color: ${(p) => p.theme.colors.mainWhite};
    font-size: 2rem;
    margin: 0;
  }
`;

export default MovieCardStyle;
