//********** Declaration des variables de reception()  ***************************************************
char consigne[6];               //Contient la consigne mise en forme recue sur port serie
char caracteresRecus[10];       //Contient la consigne brute recue sur le port serie
int index = 0;                  //Index pour mise en forme consigne        
boolean consigneRecue = 0;      //Indique qu'une consigne est en attente de traitement

//********** Declaration des variable pour la gestion des relais*******************************************
int relaisPin[] = {2, 3, 4, 5, 6, 7, 8, 13};    //Pin ou sont connectés les relais
boolean etR01 = 0;                              //Memorise l'etat des relais
boolean etR02 = 0;
boolean etR03 = 0;
boolean etR04 = 0;
boolean etR05 = 0;
boolean etR06 = 0;
boolean etR07 = 0;
boolean etR08 = 0;

void setup()  //********************************************************************************************
{
  Serial.begin(9600);                         //initialise le port serie
  for(int i = 0; i < 8; i++)                  //declaration des pin relais en sortie
  {
    pinMode(relaisPin[i], OUTPUT);
    digitalWrite(relaisPin, HIGH);
  }
}

void reception()  //********** Lit et met en forme les consignes recues sur le port serie ******************
{
  if(Serial.available())                           
  {
    index = 0;
    while(Serial.available())
    {
      caracteresRecus[index] = Serial.read();
      index++;
      delay(5);
    }
    for(int i = 0; i <= 4; i++)
    {
      consigne[i] = caracteresRecus[i];
    }
    consigneRecue = 1;
  }
}

void executeConsigne()  //*********** Execute la consigne recue *********************************************
{
  if(strcmp(consigne, "7toi?") == 0)
  {
    Serial.print("7moi!"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r01on") == 0)
  {
    etR01 = 1;
    digitalWrite(relaisPin[0], HIGH);
    Serial.print("r01on"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r01of") == 0)
  {
    etR01 = 0;
    digitalWrite(relaisPin[0], LOW);
    Serial.print("r01of"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r02on") == 0)
  {
    etR02 = 1;
    digitalWrite(relaisPin[1], HIGH);
    Serial.print("r02on"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r02of") == 0)
  {
    etR02 = 0;
    digitalWrite(relaisPin[1], LOW);
    Serial.print("r02of"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r03on") == 0)
  {
    etR03 = 1;
    digitalWrite(relaisPin[2], HIGH);
    Serial.print("r03on"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r03of") == 0)
  {
    etR03 = 0;
    digitalWrite(relaisPin[2], LOW);
    Serial.print("r03of"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r04on") == 0)
  {
    etR04 = 1;
    digitalWrite(relaisPin[3], HIGH);
    Serial.print("r04on"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r04of") == 0)
  {
    etR04 = 0;
    digitalWrite(relaisPin[3], LOW);
    Serial.print("r04of"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r05on") == 0)
  {
    etR05 = 1;
    digitalWrite(relaisPin[4], HIGH);
    Serial.print("r05on"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r05of") == 0)
  {
    etR05 = 0;
    digitalWrite(relaisPin[4], LOW);
    Serial.print("r05of"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r06on") == 0)
  {
    etR06 = 1;
    digitalWrite(relaisPin[5], HIGH);
    Serial.print("r06on"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r06of") == 0)
  {
    etR06 = 0;
    digitalWrite(relaisPin[5], LOW);
    Serial.print("r06of"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r07on") == 0)
  {
    etR07 = 1;
    digitalWrite(relaisPin[6], HIGH);
    Serial.print("r07on"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r07of") == 0)
  {
    etR07 = 0;
    digitalWrite(relaisPin[6], LOW);
    Serial.print("r07of"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r08on") == 0)
  {
    etR08 = 1;
    digitalWrite(relaisPin[7], HIGH);
    Serial.print("r08on"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "r08of") == 0)
  {
    etR08 = 0;
    digitalWrite(relaisPin[7], LOW);
    Serial.print("r08of"); 
    consigneRecue = false;
  }
  if(strcmp(consigne, "12345") == 0)
  {
    if(etR01 == 0) Serial.print("ofR01");
    if(etR01 == 1) Serial.print("onR01");
    delay(110);
    if(etR02 == 0) Serial.print("ofR02");
    if(etR02 == 1) Serial.print("onR02");
    delay(110);
    if(etR03 == 0) Serial.print("ofR03");
    if(etR03 == 1) Serial.print("onR03");
    delay(110);
    if(etR04 == 0) Serial.print("ofR04");
    if(etR04 == 1) Serial.print("onR04");
    delay(110);
    if(etR05 == 0) Serial.print("ofR05");
    if(etR05 == 1) Serial.print("onR05");
    delay(110);
    if(etR06 == 0) Serial.print("ofR06");
    if(etR06 == 1) Serial.print("onR06");
    delay(110);
    if(etR07 == 0) Serial.print("ofR07");
    if(etR07 == 1) Serial.print("onR07");
    delay(110);
    if(etR08 == 0) Serial.print("ofR08");
    if(etR08 == 1) Serial.print("onR08");
    consigneRecue = 0;
  }
}

void loop()  //******************************************************************************************* 
{
  reception();                                
  if(consigneRecue == 1) executeConsigne();
}
