import styled from "styled-components";
import { responsive } from "../../commonStyles/mixins";

const MoviePageStyle = styled.main`
  .movie-page__title {
    font-size: 4rem;
    font-family: ${(p) => p.theme.typography.serif};
    color: ${(p) => p.theme.colors.baseColor};
    margin: 0;
  }

  .movieCard-grid {
    max-width: 2180px;
    margin: 3rem auto auto;

    display: grid;
    grid-template-columns: 1fr 1fr 1fr 1fr;
    grid-gap: 1rem;

    @media ${responsive.tabletPortrait} {
      grid-template-columns: 1fr 1fr;
    }

    @media ${responsive.phone} {
      grid-template-columns: 1fr;
    }
  }

  .pagination {
    justify-content: center;
  }
`;

export default MoviePageStyle;
