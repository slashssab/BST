clc;
clear all;
close all;
% [~,~,data] = xlsread('noweDanebubble.csv');
% T = cell2table(data);
% A = table2array(T);
% 
% [~,~,datastr] = xlsread('noweDaneStrong.csv');
% Tstr = cell2table(datastr);
% Astr = table2array(Tstr);
% 
% [~,~,datafib] = xlsread('noweDaneFib.csv');
% Tfib = cell2table(datafib);
% Afib = table2array(Tfib);
% 
% 
% figure
% plot(A(:,1),A(:,2)), grid on, xlabel('Iloœc elementów do przesortowania[n]'), ylabel('czas wykonywania siê algorytmu [ms]'), title('Sortowanie B¹belkowe'), hold on
% plot(A(:,1),A(:,1).^2*19/5e6-A(:,1)/1e3), hold on
% plot(A(:,1),A(:,1).^2*4.8196/1e6+A(:,1)*0.00628,'-g'), legend('Zmierzone czasy','Ograniczenie od do³u','Ograniczenie od góry'), axis([0 1e4 0 600])
% 
% subplot(121)
% plot(Astr(:,1),Astr(:,2)), grid on, xlabel('Liczba silnii[n]'), ylabel('czas wykonywania siê algorytmu [ms]'), title('Silnia'), hold on
% plot(A(:,1),A(:,1)/5e3+0.48)
% 
% subplot(122)
% plot(Afib(:,1),Afib(:,2)),  grid on, xlabel('Element ci¹gu[n]'), ylabel('czas wykonywania siê algorytmu [ms]'), title('Ci¹g Fibbonacciego'),  axis([0 52 0 2.05e6 ]), hold on
% plot(Afib(:,1),2.^(Afib(:,1)-31))
% 
clear; clc
Tz = -20;
Tw = 20;
Tp = 15;
q = 20e3;

%---------------------------------- Kp K1 K2
K2 = q/(3*(Tw-Tz)+(Tp-Tz));
K1 =3*K2;
Kp = K2*(Tp-Tz)/(Tw-Tp);

Tp1=(Kp*((q-K2*Tp+Tz*(K1+K2))/K1)+K2*Tz)/(Kp+K2);
Tw1=(q-K2*Tp+Tz*(K1+K2))/K1;
