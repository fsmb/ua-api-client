# Get Submission

Gets a submission by its unique ID for the board.

```HTTP
GET {baseUrl}/v1/submissions/{board}/{id}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - |-|-|-|-|
| baseUrl | path | True | string | The API URL. |
| board | path | True | string | The board code or `me`. |
| id | path | True | integer | The ID of the submission. |

## Responses

| Name | Type | Description |
| - |-|-|
| 200 OK | [Submission](/docs/definitions/submission.md) | Success |
| 204 No Content | | Submission not found |
| 404 Not Found | | Board code is missing or invalid. |

## Security

**Security Risk:** When retrieving submissions by ID be sure to first validate the submission ID belongs to the authenticated user when collecting the ID from the user either directly or via a URL. A malicious user could enter random IDs which could potentially be valid for the board resulting in a submission being loaded that is not valid for the user. 

**Example:** A website collects the submission ID for a UA application from the user. A malicious user goes to the site and starts entering IDs, incrementing by 1, until a successful call is made.

**Solution:** Require at least two pieces of information such as the FID and submission ID. Query for the submission using the ID and then compare the provided FID with the FID on the submission. If they do not match then fail the request. This will make it harder for a malicious user to guess a valid FID or ID.

### Scopes

| Scope | Description |
| -|-|
| ua.read | Grants the ability to read UA information. |

## Examples

[Get a Submission](#get-a-submission)
***

### Get a Submission

Get the submission for ID 1234.

#### Sample Request

```http
GET {baseUrl}/v1/submissions/me/1234
```

#### Sample Response

Status code: 200

*Note: Output is ellided.*

```json
{
    "id": 1234,
    "fid": "999999915",
    "submitDate": "2018-01-23T16:13:17",
    "application": {
        "licenseType": "MD",
        "boardName": "Texas Medical Board",
        "licenseSubtypeDetails": {
           "code": "FULL",
           "description": "Permanent Medical License"
        }
    },
    "identity": {
        "ssn": "123451111",
        "ssnLast4": "1111",
        "birthDate": "1978-08-08T00:00:00",
        "birthCity": "Houston",
        "birthStateOrProvince": {
            "code": "TX",
            "description": "Texas",
            "countryCode": "US",
            "countryDescription": "United States"
        },
        "gender": "M"
    },
    "names": {
        "legalName": {
            "firstName": "Philip",
            "middleName": "James",
            "lastName": "Testman"
        }
    },
    "addresses": {
        "forPublic": {
            "addressType": "Business",
            "lines": [
                "9665 Greenway Trail",
            ],
            "city": "Portland",
            "stateOrProvince": {
                "code": "OR",
                "description": "Oregon",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "89456"
        },
        "forBoard": {
            "addressType": "Business",
            "lines": [
                "9665 Greenway Trail",
            ],
            "city": "Portland",
            "stateOrProvince": {
                "code": "OR",
                "description": "Oregon",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "89456"
        }
    },
    "emailAddresses": {
        "forPublic": {
            "email": "noreply@fsmb.org"
        },
        "forBoard": {
            "email": "noreply@fsmb.org"
        }
    },
    "phones": {
        "forPublic": {
            "phoneType": "Business",
            "phoneNumber": "8524567856"
        },
        "forBoard": {
            "phoneType": "Mobile",
            "phoneNumber": "8524567856"
        }
    }
}
```

For more examples go to [samples](/samples/).
