# BioDesigner
BioDesigner is a web application for designing, simulating, and visualizing genetic circuits in synthetic biology. Users can create and modify genetic circuits by dragging and dropping genetic parts and devices, run simulations to analyze circuit performance, and generate visualizations to better understand the circuit's behavior.

## Features
- Interactive circuit designer for creating and modifying genetic circuits
- Toolbox with a variety of genetic parts and devices to choose from
- Properties panel for editing part-specific properties
- Simulation control panel for running simulations and analyzing performance
- Visualization service for generating circuit schematics, time-course data, and performance comparisons
- Comprehensive documentation and interactive tutorial for users new to synthetic biology
- (Optional) Community page for users to share designs, discuss ideas, and collaborate on projects
## Installation
Clone the repository and navigate to the project directory.

``` 
git clone https://github.com/yourusername/BioDesigner.git
cd BioDesigner	
```

Install the required dependencies.

``` 
dotnet restore	
```
Run the application.

```
dotnet run	
```
Open your web browser and navigate to http://localhost:7240 to use the application.

To-do List
- [ ] Implement basic application structure
- [ ] Create genetic part and device models
- [ ] Implement UI components for displaying and editing genetic parts and devices
- [ ] Create pages for circuit design, simulation, visualization, documentation, and community (optional)
- [ ] Implement CircuitDesignerCanvas component with drag-and-drop functionality and other interactions for designing genetic circuits
- [ ] Create a simulation service for running simulations, validating designs, and returning simulation results
- [ ] Implement visualization service for generating visualizations based on simulation results or user input
- [ ] Complete documentation and interactive tutorial content
- [ ] (Optional) Implement authentication and authorization system for user accounts
- [ ] (Optional) Create a community page for sharing designs, ideas, and collaborations

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
