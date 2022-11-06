import styled from "styled-components";

const MoviePageStyle = styled.main`
  .title {
    font-size: 4rem;
    font-family: ${p=>p.theme.typography.serif};
    color: ${(p) => p.theme.colors.baseColor};
  }
`;

export default MoviePageStyle;
