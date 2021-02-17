function MissionControlSweep()
    tx_pow = input('Transmitter Power(W) :');
    rx_low = input('Receiver Lower Limit Power(W) :');
    rx_high = input('Receiver Upper Limit Power(W) :');
    distance = input('Distance between receiver and transmitter(km) :');
    tx_gain = input('Transmitter Gain(dBi) :');
    rx_gain = input('Receiver Gain(dBi) :');
    Plosslower=(tx_pow/rx_low)*(tx_gain*rx_gain);
    Plossupper=(tx_pow/rx_high)*(tx_gain*rx_gain);    
    freq_low=10^((Plossupper-(32.4+20*log(distance)))/20);
    freq_up=10^((Plosslower-(32.4+20*log(distance)))/20);
    freq_up
    freq_low
    Bandwidth = freq_up-freq_low;
    Bandwidth
    disp(text);
    for f=0:0.01:500
        for d=0:0.1:distance
            Ploss=32.4+20*log(f)+20*log(d);
            plot3(d,f,Ploss,'*')
            title('Free Space Path Loss')
            xlabel('Distance, (km)')
            ylabel('Frequency, (MHz)')
            zlabel('Free Space Path Loss, (dB)')
            grid on
            hold on
            Ploss=[];
        end
    end
    hold off
end
function TVAntennaArea()
    rx_pow = input('Receiver Power(W) :');
    tx_gain = input('Transmitter Gain(dBi) :');
    rx_gain = input('Receiver Gain(dBi) :');
    freq=[57,177,195,213,527];
    dist=sqrt(1000/pi);
    PlossMax=[];
    tx_pow=[];
    for t=1:5
        PlossMax(t)=32.4+20*log(freq(t))+20*log(dist);     
        tx_pow1(t)=(rx_pow/PlossMax(t))*(tx_gain*rx_gain);
    end
    
    PlossMax
    tx_pow1
end
