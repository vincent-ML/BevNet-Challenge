import styled from "styled-components";

const SearchStyle = styled.div`
  color: ${(p) => p.theme.colors.lightGray};
  font-size: 1.3rem;
  font-family: ${(p) => p.theme.typography.sansSerif};
  font-weight: 700;
  background-color: ${(p) => p.theme.colors.darkGray};
  padding: 3rem 2rem;
  margin-top: 3rem;
  border-radius: 1rem;
  min-width: 30rem;

  h2 {
    margin: 0;
    text-transform: uppercase;
  }

  .controls {
    margin-top: 1rem;
    display: flex;

    input[type="text"] {
      padding: 0.7rem;
      margin-right: 7px;
      font-size: 1.6rem;
      font-family: ${(p) => p.theme.typography.sansSerif};
      border: 1px solid ${(p) => p.theme.colors.lightGray};
      background-color: ${(p) => p.theme.colors.darkGray};
      width: 40rem;
      border-radius: 0.7rem;
      color: ${(p) => p.theme.colors.lightGray};
    }

    input[type="text"]::placeholder {
      opacity: 1;
      font-size: 1.6rem;
      color: ${(p) => p.theme.colors.midGray};
    }

    input[type="text"]:focus {
      transition: border 0.8s;
      outline: none;
      border: none;
      border: 1px solid ${(p) => p.theme.colors.baseColor};
    }

    button {
      border-radius: 0.7rem;
      background-color: ${(p) => p.theme.colors.midGray};
      outline: none;
      border: 1px solid transparent;
      padding: 0.5rem;
      width: 10rem;

      img {
        height: 70%;
      }
    }

    button:hover {
      background-color: ${(p) => p.theme.colors.mainGray};
    }

    button:focus {
      border: 1px solid ${(p) => p.theme.colors.baseColor};
    }
  }
`;

export default SearchStyle;
