import { createGlobalStyle } from "styled-components";
import playfairDisplayBold from "../assets/fonts/Playfair_Display/PlayfairDisplay-Bold.ttf";
import robotoBold from "../assets/fonts/Roboto/Roboto-Bold.ttf";
import robotoRegular from "../assets/fonts/Roboto/Roboto-Regular.ttf";

const Fonts = createGlobalStyle`
  @font-face {
    font-family: 'Roboto';
    src: url(${robotoRegular}) format("truetype");
    font-weight: 400;
  }

  @font-face {
    font-family: 'Roboto';
    src: url(${robotoBold}) format("truetype");
    font-weight: 700;
  }

  @font-face {
    font-family: 'Playfair Display';
    src: url(${playfairDisplayBold}) format("truetype");
    font-weight: 700;
  }
`;

export default Fonts;
