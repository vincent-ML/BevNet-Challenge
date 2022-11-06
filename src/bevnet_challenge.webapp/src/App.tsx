import { ThemeProvider } from "styled-components";
import Fonts from "./commonStyles/fonts";
import GlobalStyle from "./commonStyles/globalStyle";
import { mainTheme } from "./commonStyles/theming";
import MoviePage from "./views/moviePage";

function App() {
  return (
    <ThemeProvider theme={mainTheme}>
      <GlobalStyle />
      <Fonts />
      <MoviePage />
    </ThemeProvider>
  );
}

export default App;
