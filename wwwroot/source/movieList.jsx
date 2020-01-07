import React from 'react';
import Movie from './movie.jsx'
class MovieList extends React.Component {
     constructor(props) {
          super(props);
          this.state = { data: [] };
     }
     loadMovies() {
          const xhr = new XMLHttpRequest();
          xhr.open('get', this.props.url, false);
          xhr.onload = () => {
               const data = JSON.parse(xhr.responseText);
               this.setState({ data: data });
          };
          xhr.send();
     }
     componentWillMount() {
          this.loadMovies();
     }
     render() {
          const movies = this.state.data.map(movie => (
          <Movie key={movie.id} movieName={movie.name} movieYear={movie.year} />
          ));
          return (
               <div>{movies}</div>
          );
     }
};
export default MovieList;