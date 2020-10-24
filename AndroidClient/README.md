# Kontroller Android Client

This is an application to control PC by sending HTTP requests.

## How to use?

Enter your computer IP and port like this

```
192.168.1.102:2714
```

And put your key, this key should be same as the key what you use to run NetServer.

Take a test, if you get success toast, then enjoy it!

Else, if it is failed, just try check your computer firewall, anti-virus application and related settings.

## What will do during using?

1. We may generate TOTP token by your key.
2. Use token and request to command the server-side to do the thing.
