import React from 'react';
class Movie extends React.Component{
     render() {
          return (
               <div>{this.props.movieName} ({this.props.movieYear})</div>
          );
      }
};
export default Movie;