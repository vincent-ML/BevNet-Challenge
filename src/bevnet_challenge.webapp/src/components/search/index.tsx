import { useState } from "react";
import search from "../../assets/icons/search.svg";
import SearchStyle from "./style";

interface SearchProps {
  searchHandler: (title: string) => void;
}

export default function Search(props: SearchProps) {
  const [title, setTitle] = useState<string>("");

  const onKeyPressed = (e: React.KeyboardEvent) => {
    if (e.key === "Enter") {
      props.searchHandler(title);
    }
  };

  return (
    <SearchStyle>
      <h2>Movie Search</h2>
      <div className='controls'>
        <input
          type='text'
          id='title'
          name='title'
          placeholder='Movie Title'
          onChange={(e) => setTitle(e.target.value)}
          onKeyPress={onKeyPressed}
        />
        <button onClick={() => props.searchHandler(title)}>
          <img src={search} alt='Search Icon' />
        </button>
      </div>
    </SearchStyle>
  );
}
