close all;
figure(1);
hold off;
plot(Positions(:,:),Time,'black.','MarkerSize',1);
xlabel('Position [m]');
ylabel('Time [m]');
axis([0 800 0 2000]);
figure(2);
hold off;
plot(Time,Velocity(:,:),'.','MarkerSize',1);
hold on;
figure(3);
hold off;
plot(Time,Acceleration(:,:),'.','MarkerSize',1);
hold on;
%for i = 1:50
%    figure(i+4);
%    plot(Time,Velocity(:,i),'-','MarkerSize',1);
%end

% Flow = cars/h, measure cars at a given point, for example pos = 0
% Density = vehicles/km, measure +-20m?

figure(4);
hold off;
g = Positions';
[B,IX] = sort(g);
f = Velocity';

for j = 1:1:1 %size(f,2);
    C(:,j) = f(IX(:,j),j); 
    plot(B(:,j),C(:,j),'MarkerSize',8);
    axis([0 800 0 50]);
    pause(0.05);
end

