# UnityIgra
Repozitorij namenjen za našo Unity igro, za predmet RGTI.


Aleksander 8/12/2017, 17.25 :
@Simon: Lahko že začneš delati Assete za Unity igro. Lahko narediš že celoten meni - text (font NI OK,...), animacija namesto statične slike, slider.... Dodatno bi še rabili dropdown
slikce za 1920*1080. Kot 2D asset bi bili tudi kul markerji za top down kamero ( naj bodo čim večje - lažje jih je potem downscalati, kot pa up)
Mitja: Malo si poglej novejše uradne tutirial, ker koda za movement je: bistveno krajša:

void FixedUpdate ()
  {
     float moveHorizontal = Input.GetAxis ("Horizontal");
     float moveVertical = Input.GetAxis ("Vertical");

     Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

     rb.AddForce (movement * speed);
   }