The main focus of this initial commit is to establish the proof of concept (PoC) by validating the handling, generation, and mapping of links.

Current Status
The code, as demonstrated in the video, is functional in its main parts. It correctly executes the business logic within a console environment but is not yet implemented as a web service.

Implemented Components and Logic:
URL Processing: Utilization of the System.Uri class for robust parsing and decomposition of the original URL into its components (Host, Path, Query, etc.).

Unique Key Generation: Use of System.Guid to generate a unique identifier, which is then formatted to serve as the short path for the new link.

In-Memory Storage: Employment of a Dictionary<string, string> to map the generated short key to the original URL. This currently serves as a temporary substitute for a database.

Limitations and Next Steps
As this is an initial phase, the project does not yet have:

Persistence Layer: A database (SQL or NoSQL) to store the mappings permanently.

Server/API: A service layer (such as an ASP.NET Core API) to receive HTTP requests (for shortening and redirecting) and interact with the user.

The future goal is to evolve this proof of concept into a complete web service by implementing the API and persistence layers.
