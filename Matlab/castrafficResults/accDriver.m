%% Export from TrafficSim. Date: 2009-12-09 Time: 04:30

% RoadRadius (m) = 127.32
% RoadLength (m) = 800.00
% TimeStep (s) = 0.05
% SpeedLimit (km/h) = 50.00

% Maximum deviation of start position (m) = 1.00
% TimeHeadway (s) = 1.50
% MaxAcceleration (m/(s^2)) = 0.73
% MaxBrake (m/(s^2)) = 1.63
% DriverReactionTime (s) = 0.2
% AdaptionToNextNextVehicle () = 0.00

%% ACC DRIVER. Simulation notes by Sebastian Johansson:
% Jams starts at 56.3 cars/km (45 cars @ 800 road). First 3-4 fronts -> 1 sustained
% Method: Run until jams appear (if any), wait until vel/flow is stable. Note value.

% Average velocity (km/h)
Velocity=[49.7 48.9 47.4 45.1 42.1 38.4 34.2 30.0 24.0 20.0 17.1 14.7 12.6 10.9];

% Average traffic flow (cars/h)
Flow=[310.9 611.3 888.5 1128.2 1315.6 1439.9 1498.3 1499.5 1347.0 1248.2 1177.5 1103.8 1027.5 952.7];

% Average density (cars/km)
Density=[6.3 12.5 18.8 25.0 31.3 37.5 43.8 50.0 56.3 62.5 68.8 75.0 81.3 87.5];

% Number of cars on road (cars)
NumOfCars=[5 10 15 20 25 30 35 40 45 50 55 60 65 70];