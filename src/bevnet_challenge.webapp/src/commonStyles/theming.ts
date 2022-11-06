const userActionColors = {
  success: "#44D2B1",
  danger: "#CD3C42",
  warning: "#FFA205",
};

const mainColors = {
  baseColor: "#F2B705",
};

const neutralColors = {
  mainBlack: "#111315",
  darkGray: "#222425",
  mainGray: "#4C5057",
  midGray: "#707070",
  lightGray: "#CED3DE",
  mainWhite: "#F9F9F9",
  pureWhite: "#FFFFFF",
};

const typography = {
  sansSerif: "'Roboto', 'Arial', 'Helvetica', Sans-Serif",
  serif: "'Playfair Display', 'Times New Roman', Serif",
};

const shadows = {
  bigShadow: "0 1.5rem 4rem rgba(43,47,52, .17)",
  smallShadow: "0 .7rem 1.2rem  rgba(43,47,52, .17)",
};

export const mainTheme = {
  colors: {
    ...userActionColors,
    ...mainColors,
    ...neutralColors,
  },
  typography,
  shadows,
};

export type theme = typeof mainTheme;
