
# Search Doc Req

## Structure

`SearchDocReq`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayerNumber` | `string` | Required | Payer Number of the selected payer.<br>Mandatory<br>Example: GB000000123 |
| `AccountNumber` | `string` | Optional | Account Number of the customer.<br>Mandatory for customer users else optional.<br>This input is a search criterion, if given.<br>Example: GB000000123 |
| `AccountNumberList` | `List<string>` | Optional | Account Number of the customers.<br>optional.<br>This input is a search criterion, if given.<br>Example: [“GB00000123”, “GB00000225”] |
| `InvoiceNumber` | `string` | Optional | Invoice number.<br>Optional if InvoiceNumberList is passed else Mandatory<br>This input is a search criterion, if given.<br>Example: 0123456789 |
| `InvoiceNumberList` | `List<string>` | Optional | List of Invoice number.<br>Optional if InvoiceNumber is passed else Mandatory<br>Example: [“0123456789”, “0123459799”] |
| `InvoiceStatus` | `string` | Optional | The status of the invoices<br>Optional<br>One of the following values:<br>•    NEW<br>•    VIEWED<br>•    DOWNLOADED<br>•    RESTORED |
| `IssuingDateFrom` | `string` | Optional | Invoice Issuing Date Range/From<br>Optional<br>Format: yyyy/MM/dd |
| `IssuingDateTo` | `string` | Optional | Invoice Issuing Date Range/To<br>Optional<br>Format: yyyy/MM/dd |
| `DueDateFrom` | `string` | Optional | Invoice Due Date Range/From<br>Optional<br>Format: yyyy/MM/dd |
| `DueDateTo` | `string` | Optional | Invoice Due Date Range/To<br>Optional<br>Format: yyyy/MM/dd |
| `GrossAmount` | `string` | Optional | Gross amount of the bill.<br>Optional |
| `GrossAmountOperator` | `string` | Optional | Criteria on the gross amount, for instance use GT when to retrieve the invoices for that gross amount is greater than the given amount on GrossAmount parameter above.<br>Optional<br><br>This parameter will be ignored if GrossAmount parameter is not set.<br><br>One of the following values:<br>•    LT (Less Than)<br>•    LE (Lesser or Equal)<br>•    EQ (equal)<br>•    GE (Greater or equal)<br>•    GT (Greater than) |
| `DocumentType` | `string` | Optional | Document Type<br>Optional<br>One of the following values:<br>•    NAT (National)<br>•    INT (International)<br>•    SOA (Statement of Account) |
| `VATIssuerCountry` | `string` | Optional | Two letter ISO country code. |
| `SortyBy` | `List<string>` | Optional | Collecting Company Code of the selected payer.<br>Mandatory<br>Example:<br>86-Philippines<br>5-UK |
| `ColCoCode` | `int?` | Required | Collecting Company Code of the selected payer.<br>Mandatory<br>Example:<br>86-Philippines<br>5-UK |

## Example (as JSON)

```json
{
  "PayerNumber": "PayerNumber0",
  "AccountNumber": "AccountNumber2",
  "AccountNumberList": [
    "AccountNumberList0"
  ],
  "InvoiceNumber": "InvoiceNumber0",
  "InvoiceNumberList": [
    "InvoiceNumberList5"
  ],
  "InvoiceStatus": "InvoiceStatus4",
  "ColCoCode": 50
}
```

