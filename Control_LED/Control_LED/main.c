/*
 * Control_LED.c
 *
 * Created: 29-Oct-19 3:09:07 PM
 * Author : quann
 */ 

#include <avr/io.h>
#include <avr/interrupt.h>

//chuong trinh chon truyen du lieu
void led_control(unsigned char chr)
{
	PORTB = chr;
}

void sent_data(unsigned char chr)
{
	//while (bit_is_clear(UCSRA, UDRE));
	//UDR = chr;
	
	while (bit_is_clear(UCSRA,UDRE)) {}; //cho den khi bit UDRE=1
	UDR=chr;
}

volatile unsigned char u_Data;

int main(void)
{
    //set khung truyen 57600
	UBRRH = 0;
	UBRRL =8;
	//set cong xuat B
	DDRB = 0xFF;
	
	//SET THANH GHI
	UCSRA = 0x00;
	UCSRC = (1<<URSEL)|(1<<UCSZ1) | (1<<UCSZ0);
	UCSRB = (1<<RXCIE)|(1<<RXEN) |(1<<TXEN);
	sei();
	
    while (1)
	{
		sent_data(PINB);
	}
}

ISR(USART_RXC_vect){
	u_Data = UDR;
	led_control(u_Data);
}



