crazy-crypto
============

"Crypto" is a small standalone windows application for encryption and decryption. 

Encryption: (Sender Side) 
-------------------------
Crypto converts the text(plaintext) into encrypted text (ciphertext). 
In 'D:' drive, a file named 'cipher.txt' consists of ciphertext. 
The file named "gps.txt" is the key which will be required for decrypting the ciphertext back to plaintext.


Open the project "WindowsApplication-Crypto.vbproj" and run the project.

-Defaults:
  -ID : crypto
  -password : jash
  
  
For encrypting the text, just enter the plaintext and click on "encrypt" button. After clicking, those 2 files mentioned above will be generated in 'D:' drive.

The cipher.txt can be sent to receiver normally but gps.txt should safely reach to receiver.


Decryption: (Receiver Side)
---------------------------
When the receiver reveives the cipher text, one needs to enter the "decrypt" mode of windows app and paste ciphertext in the text area.
Once this is done, one can click on "key" image for loading the key. Select "gps.txt" and click on "decrypt".

VOILA.. You will get the original plaintext back. 

P.S - This is not a final product or not even a great one. It may (and is) buggy. You can make this application as base and work further. 

Thank you.
