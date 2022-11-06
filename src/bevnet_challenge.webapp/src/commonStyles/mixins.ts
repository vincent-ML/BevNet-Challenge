import { css } from "styled-components";

const absCenter = css`
  position: absolute;
  top: 50%;
  left: 50%;
  -webkit-transform: translate(-50%, -50%);
  -ms-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
`;

const screenSizes = {
  phone: "37.5em",
  tabletPortrait: "60.94em",
  tabletLandscape: "75em",
  bigDesktop: "112.5em",
};

const responsive = {
  phone: `only screen and  (max-width: ${screenSizes.phone})`,
  tabletPortrait: `only screen and (max-width: ${screenSizes.tabletPortrait})`,
  tabletLandscape: `only screen and (max-width: ${screenSizes.tabletLandscape})`,
  bigDesktop: `only screen and (min-width: ${screenSizes.bigDesktop})`,
};

export { absCenter, responsive };
