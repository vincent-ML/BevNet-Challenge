import React from "react";
import MoviePageStyle from "./style";

export default class MoviePage extends React.Component {
  render(): React.ReactNode {
    return (
      <MoviePageStyle>
        <h1 className='title'>BevNet Challenge</h1>
      </MoviePageStyle>
    );
  }
}
