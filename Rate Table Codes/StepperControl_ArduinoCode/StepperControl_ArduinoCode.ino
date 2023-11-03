//SpaceLab
//Hecho por Mauricio Cristaldo

#include <AccelStepper.h>

// Definir el tipo de motor y los pines a los cuales será conectado
AccelStepper stepper(1, 2, 5); // (Type of stepper: 1 for "DRIVER", connected to pins 2 (step), and 5 (dir))

// Definir variables para los datos
int direction;
int gear = 60 / 20;                       // Reducción del sistema de engranajes
float k = 1.8 / 16;                      // Definir la resolución del motor (1.8 degrees / 4 debido al encendido del microstep 2 del driver)
float angularVelocity = gear * 37 / k; // Definir una velocidad angular constante
float targetAngle;                     // Definir objetivo de movimiento
float time;                           // Definir la variable tiempo
long position;                       // Variable de posición en pasos

void setup() 
{
  // Preparar la comunicación serial con el GUI
  Serial.begin(115200);
  
  // Definir la velocidad máxima y la posición actual
  stepper.setMaxSpeed(1000);            // 1000 steps / sec MAX == 112.5 deg / sec motor's speed == 37.5 deg / sec table's speed
  stepper.setSpeed(angularVelocity);   // Preparar la velocidad
  stepper.setCurrentPosition(0);      // Asignar la posición actual como "0"
  pinMode(3, OUTPUT);                //Microsteps del Driver encendidos
  pinMode(4, OUTPUT);               //""
  pinMode(6, OUTPUT);              //""
  digitalWrite(3, HIGH); 
  digitalWrite(4, HIGH);         //""
  digitalWrite(6, HIGH);        // Microsteps del Driver encendidos
}

void loop() {
  if (Serial.available() > 0) {
    // Leer el comando recibido
    char command = Serial.read();
    // Manejar diferentes comandos
    switch (command) {
      case 'd':
        Serial.print("Direction: ");
        // Elegir dirección (1 para CW, 0 para CCW) (MOTOR)
        direction = Serial.parseInt();
        if (direction == 1)
        {
          k = -abs(k);
          Serial.println("CW");
        }
        else if (direction == 0)
          k = abs(k);
          Serial.println("CCW");
        break;

      case 'r':
        // Colocar ángulo objetivo (en grados)
        targetAngle = Serial.parseFloat();
        Serial.print("Ángulo incremental (deg): ");
        Serial.println(targetAngle);
        stepper.move(gear * targetAngle / k);
        break;

      case 'R':
        // Colocar ángulo absoluto (en grados)
        targetAngle = Serial.parseFloat();
        Serial.print("Ángulo absoluto (deg) : ");
        Serial.println(targetAngle);
        stepper.moveTo(gear * targetAngle / k);
        break;
        
      case 't':
        // Definir cantidad de tiempo de giro en el Control de Velocidad
        time = Serial.parseFloat();
        Serial.print("Tiempo: ");
        Serial.println(time);
        break;
      
      case 'v':
        if (time != 0)
        {
          // Definir velocidad angular (Grados por segundo)
          angularVelocity = Serial.parseFloat();
          if (angularVelocity < 37)
          {
          digitalWrite(3, HIGH); 
          digitalWrite(4, HIGH);
          digitalWrite(6, HIGH);
          k = 1.8 / 16;
          Serial.print("Velocidad Angular (°/seg): ");
          Serial.print(angularVelocity); // Grados por segundo
          angularVelocity = gear * angularVelocity / k;
          Serial.print("  Velocidad Angular (Steps / sec): ");
          Serial.print(angularVelocity); // Pasos por segundo
          stepper.setSpeed(angularVelocity);
          stepper.move(angularVelocity * time);
          }
          else if (angularVelocity >= 37 && angularVelocity < 75)
          {
          digitalWrite(3, HIGH); 
          digitalWrite(4, HIGH);
          digitalWrite(6, LOW);
          k = 1.8 / 8;
          Serial.print("Velocidad Angular (°/seg): ");
          Serial.print(angularVelocity); // Grados por segundo
          angularVelocity = gear * angularVelocity / k;
          Serial.print("  Velocidad Angular (Steps / sec): ");
          Serial.print(angularVelocity); // Pasos por segundo
          stepper.setSpeed(angularVelocity);
          stepper.move(angularVelocity * time);
          }
          else if (angularVelocity >= 75 && angularVelocity < 150)
          {
          digitalWrite(3, LOW); 
          digitalWrite(4, HIGH);
          digitalWrite(6, LOW);
          k = 1.8 / 4;
          Serial.print("Velocidad Angular (°/seg): ");
          Serial.print(angularVelocity); // Grados por segundo
          angularVelocity = gear * angularVelocity / k;
          Serial.print("  Velocidad Angular (Steps / sec): ");
          Serial.print(angularVelocity); // Pasos por segundo
          stepper.setSpeed(angularVelocity);
          stepper.move(angularVelocity * time);
          }
          else if (angularVelocity >= 150 && angularVelocity < 300)
          {
          digitalWrite(3, HIGH); 
          digitalWrite(4, LOW);
          digitalWrite(6, LOW);
          k = 1.8 / 2;
          Serial.print("Velocidad Angular (°/seg): ");
          Serial.print(angularVelocity); // Grados por segundo
          angularVelocity = gear * angularVelocity / k;
          Serial.print("  Velocidad Angular (Steps / sec): ");
          Serial.print(angularVelocity); // Pasos por segundo
          stepper.setSpeed(angularVelocity);
          stepper.move(angularVelocity * time);
          }
          else if (angularVelocity >= 300 && angularVelocity < 600)
          {
          digitalWrite(3, LOW); 
          digitalWrite(4, LOW);
          digitalWrite(6, LOW);
          k = 1.8;
          Serial.print("Velocidad Angular (°/seg): ");
          Serial.print(angularVelocity); // Grados por segundo
          angularVelocity = gear * angularVelocity / k;
          Serial.print("  Velocidad Angular (Steps / sec): ");
          Serial.print(angularVelocity); // Pasos por segundo
          stepper.setSpeed(angularVelocity);
          stepper.move(angularVelocity * time);
          }
        }
        else
        Serial.println("Operando Control de Posicion");
        break;
    }
  }
  // Actualizar motor
  stepper.setSpeed(angularVelocity);
  stepper.runSpeedToPosition();

  //Obtener posición
  position = stepper.currentPosition(); // Conocer la posición actual del motor en pasos
  position = position * k / gear;      // Conocer la posición actual de la base superior
  
}
