# Kontroller

Kontroller is a tool to help control local-network computer with mobile.

## API Design

```
action?token=<OtpToken>&want=<WantToDo>
```

- OtpToken
  * This param is to check your permission to control.
- WantToDo
  * This param is to control your PC.
    | Command       | Things to do  |
    | ------------- | ------------  |
    | `vol-up`      | Add volume    |
    | `vol-down`    | Down volume   |
    | `vol-mute`    | Mute          |
    | `media-next`  | Play next     |
    | `media-prev`  | Play previous |
    | `media-stop`  | Play/Pause    |
    | `media-pause` | Play/Pause    |
    | `media-play`  | Play/Pause    |
 