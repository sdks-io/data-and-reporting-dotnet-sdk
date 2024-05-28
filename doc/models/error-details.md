
# Error Details

## Structure

`ErrorDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Error code representing the error encountered |
| `Title` | `string` | Optional | Error type description |
| `Detail` | `string` | Optional | Detailed inforamtion about the error |
| `AdditionalInfo` | `Dictionary<string, string>` | Optional | Applicable when more details related to error to be returned |

## Example (as JSON)

```json
{
  "Code": "Code2",
  "Title": "Title8",
  "Detail": "Detail4",
  "AdditionalInfo": {
    "key0": "AdditionalInfo2"
  }
}
```

