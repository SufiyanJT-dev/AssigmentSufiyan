// Declare the array
const students = [
  { FirstName: "John", LastName: "Doe", Age: 20, Department: "Computer Science" },
  { FirstName: "Jane", LastName: "Smith", Age: 22, Department: "Physics" },
  { FirstName: "Michael", LastName: "Johnson", Age: 21, Department: "Mathematics" },
  { FirstName: "Sarah", LastName: "Williams", Age: 19, Department: "Computer Science" },
  { FirstName: "Robert", LastName: "Brown", Age: 23, Department: "Mathematics" },
  { FirstName: "Emily", LastName: "Davis", Age: 20, Department: "Computer Science" }
];

// 1 List students in Computer Science
const csStudents = students.filter(s => s.Department === "Computer Science");
console.log("Computer Science Students:", csStudents);

// 2 First names of students with age > 21
const namesAbove21 = students.filter(s => s.Age > 21).map(s => s.FirstName);
console.log("First names (Age > 21):", namesAbove21);

// 3 Check if Robert is in Computer Science
const isRobertInCS = students.some(s => s.FirstName === "Robert" && s.Department === "Computer Science");
console.log("Is Robert in CS:", isRobertInCS);

// 4 Any student with age > 23 in Mathematics?
const isAgeAbove23InMaths = students.some(s => s.Age > 23 && s.Department === "Mathematics");
console.log("Age > 23 in Maths:", isAgeAbove23InMaths);

// 5 Are all students older than 18?
const areAllAbove18 = students.every(s => s.Age > 18);
console.log("All above 18:", areAllAbove18);

// 6 Print department of John
const johnDept = students.find(s => s.FirstName === "John")?.Department;
console.log("John's Department:", johnDept);
// Declare the array
let movies = [
  { MovieName: "The Great Adventure", ActorName: "John Smith", ReleaseDate: "2023-01-15" },
  { MovieName: "Mystery in the Woods", ActorName: "Emily Johnson", ReleaseDate: "2022-09-28" },
  { MovieName: "Love and Destiny", ActorName: "Michael Brown", ReleaseDate: "2023-05-02" },
  { MovieName: "City of Shadows", ActorName: "Sophia Williams", ReleaseDate: "2023-03-12" },
  { MovieName: "The Last Stand", ActorName: "William Davis", ReleaseDate: "2022-11-07" },
  { MovieName: "Echoes of Time", ActorName: "Olivia Wilson", ReleaseDate: "2022-12-19" }
];

// 1 Movies released in 2022 with actor name
const movies2022 = movies
  .filter(m => m.ReleaseDate.startsWith("2022"))
  .map(m => ({ MovieName: m.MovieName, ActorName: m.ActorName }));
console.log("Movies in 2022:", movies2022);

// 2 Movies in 2023 with actor William Davis
const william2023 = movies
  .filter(m => m.ReleaseDate.startsWith("2023") && m.ActorName === "William Davis")
  .map(m => m.MovieName);
console.log("2023 movies by William Davis:", william2023);

// 3 Actor name + release date of "The Last Stand"
const lastStandDetails = movies.find(m => m.MovieName === "The Last Stand");
console.log("The Last Stand details:", { ActorName: lastStandDetails?.ActorName, ReleaseDate: lastStandDetails?.ReleaseDate });

// 4 Any movie with actor John Doe?
const hasJohnDoe = movies.some(m => m.ActorName === "John Doe");
console.log("Any movie with John Doe:", hasJohnDoe);

// 5 Count of movies where actor = Sophia Williams
const sophiaCount = movies.filter(m => m.ActorName === "Sophia Williams").length;
console.log("Movies with Sophia Williams:", sophiaCount);

// 6 Insert a new element at the end
movies.push({ MovieName: "The Final Stage", ActorName: "John Doe", ReleaseDate: "2022-08-11" });
console.log("After adding new movie:", movies);

// 7 Check for duplicate movie names
const hasDuplicateMovies = movies.map(m => m.MovieName)
  .some((name, idx, arr) => arr.indexOf(name) !== idx);
console.log("Any duplicate movie names:", hasDuplicateMovies);

// 8 Create a new array starting from "City of Shadows"
const startIndex = movies.findIndex(m => m.MovieName === "City of Shadows");
const newArrayFromCity = movies.slice(startIndex);
console.log("New array from 'City of Shadows':", newArrayFromCity);

// 9 Distinct actor names
const distinctActors = [...new Set(movies.map(m => m.ActorName))];
console.log("Distinct actor names:", distinctActors);

// 10 Insert "Rich & Poor" next to "Love and Destiny"
const loveIndex = movies.findIndex(m => m.MovieName === "Love and Destiny");
movies.splice(loveIndex + 1, 0, {
  MovieName: "Rich & Poor",
  ActorName: "Johnie Walker",
  ReleaseDate: "2023-08-11"
});
console.log("After inserting 'Rich & Poor':", movies);

// 11 Count of distinct actor names
const distinctActorCount = distinctActors.length;
console.log("Count of distinct actors:", distinctActorCount);

// 12 Remove movie "The Last Stand"
movies = movies.filter(m => m.MovieName !== "The Last Stand");
console.log("After removing 'The Last Stand':", movies);

// 13 Check if all movies are released after 2021-12-31
const allAfter2021 = movies.every(m => new Date(m.ReleaseDate) > new Date("2021-12-31"));
console.log("All after 2021-12-31:", allAfter2021);

// 14 Update release date of "City of Shadows"
movies = movies.map(m => 
  m.MovieName === "City of Shadows" ? { ...m, ReleaseDate: "2023-03-13" } : m
);
console.log("Updated City of Shadows:", movies.find(m => m.MovieName === "City of Shadows"));

// 15 Movies with name length > 10
const longNameMovies = movies.filter(m => m.MovieName.length > 10).map(m => m.MovieName);
console.log("Movie names (length > 10):", longNameMovies);

