
# Warning

## Structure

`Warning`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Required | A custom message giving the detailed outage information. The message will contain the duration and the reason for the outage. |
| `Type` | `string` | Required | Type of warning |

## Example (as JSON)

```json
{
  "Message": "System is down for upgradation.",
  "Type": "System Outage"
}
```

