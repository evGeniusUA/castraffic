close all;
figure(1);
hold off;
plot(Positions(:,:),Time,'.','MarkerSize',1);
figure(2);
hold off;
plot(Time,Velocity(:,:),'.','MarkerSize',1);
hold on;
%for i = 1:50
%    figure(i+4);
%    plot(Time,Velocity(:,i),'-','MarkerSize',1);
%end

    
figure(3);
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

