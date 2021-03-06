﻿Feature: UsersErrors
	Check the errors returned by the /Users endpoint

Scenario: Error is returned when schemas attribute is missing (HTTP POST)
	When execute HTTP POST JSON request 'http://localhost/Users'
	| Key | Value |

	And extract JSON from body

	Then HTTP status code equals to '400'
	Then JSON 'status'='400'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='400'
	Then JSON 'response.scimType'='invalidSyntax'
	Then JSON 'response.detail'='Request is unparsable, syntactically incorrect, or violates schema.'

Scenario: Error is returned when schema is not valid (HTTP POST)
	When execute HTTP POST JSON request 'http://localhost/Users'
	| Key		| Value					|
	| schemas	| [ "invalidschema" ]	|

	And extract JSON from body

	Then HTTP status code equals to '400'
	Then JSON 'status'='400'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='400'
	Then JSON 'response.scimType'='invalidSyntax'
	Then JSON 'response.detail'='Request is unparsable, syntactically incorrect, or violates schema.'

Scenario: Error is returned when trying to add two resources with the same unique attribute
	When execute HTTP POST JSON request 'http://localhost/Users'
	| Key		| Value																									|
	| schemas	| [ "urn:ietf:params:scim:schemas:core:2.0:User" ]														|
	| userName	| bjen																									|
	| name		| { "formatted" : "formatted", "familyName": "familyName", "givenName": "givenName" }					|

	
	When execute HTTP POST JSON request 'http://localhost/Users'
	| Key		| Value																									|
	| schemas	| [ "urn:ietf:params:scim:schemas:core:2.0:User" ]														|
	| userName	| bjen																									|
	| name		| { "formatted" : "formatted", "familyName": "familyName", "givenName": "givenName" }					|

	And extract JSON from body

	Then HTTP status code equals to '409'
	Then JSON 'status'='409'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='409'
	Then JSON 'response.scimType'='uniqueness'
	Then JSON 'response.detail'='One or more of the attribute values are already in use or are reserved.'

Scenario: Error is returned when the user doesn't exist (HTTP GET)
	When execute HTTP GET request 'http://localhost/Users/1'
	
	And extract JSON from body

	Then HTTP status code equals to '404'
	Then JSON 'status'='404'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.detail'='Resource 1 not found.'

Scenario: Error is returned when trying to remove an unknown user (HTTP DELETE)
	When execute HTTP DELETE request 'http://localhost/Users/1'
	
	And extract JSON from body

	Then HTTP status code equals to '404'
	Then JSON 'status'='404'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.detail'='Resource 1 not found.'

Scenario: Error is returned when schemas attribute is missing (HTTP PUT)
	When execute HTTP PUT JSON request 'http://localhost/Users/id'
	| Key | Value |

	And extract JSON from body

	Then HTTP status code equals to '400'
	Then JSON 'status'='400'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='400'
	Then JSON 'response.scimType'='invalidSyntax'
	Then JSON 'response.detail'='Request is unparsable, syntactically incorrect, or violates schema.'

Scenario: Error is returned when schema is not valid (HTTP PUT)
	When execute HTTP PUT JSON request 'http://localhost/Users/id'
	| Key		| Value					|
	| schemas	| [ "invalidschema" ]	|

	And extract JSON from body

	Then HTTP status code equals to '400'
	Then JSON 'status'='400'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='400'
	Then JSON 'response.scimType'='invalidSyntax'
	Then JSON 'response.detail'='Request is unparsable, syntactically incorrect, or violates schema.'

Scenario: Error is returned when trying to update an unknown resource (HTTP PUT)
	When execute HTTP PUT JSON request 'http://localhost/Users/id'
	| Key		| Value																									|
	| schemas	| [ "urn:ietf:params:scim:schemas:core:2.0:User" ]														|

	And extract JSON from body

	Then HTTP status code equals to '404'
	Then JSON 'status'='404'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='404'
	Then JSON 'response.scimType'='notFound'
	Then JSON 'response.detail'='Resource does not exist'

Scenario: Error is returned when update an immutable attribute (HTTP PUT)
	When execute HTTP POST JSON request 'http://localhost/Users'
	| Key		| Value																									|
	| schemas	| [ "urn:ietf:params:scim:schemas:core:2.0:User" ]														|
	| userName	| bjen																									|
	| name		| { "formatted" : "formatted", "familyName": "familyName", "givenName": "givenName" }					|
	
	And extract JSON from body
	And extract 'id' from JSON body	
	And execute HTTP PUT JSON request 'http://localhost/Users/$id$'
	| Key		| Value												|
	| schemas   | [ "urn:ietf:params:scim:schemas:core:2.0:User" ]	|
	| immutable | str												|
	
	And extract JSON from body
	
	Then HTTP status code equals to '400'
	Then JSON 'status'='400'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='400'
	Then JSON 'response.scimType'='mutability'

Scenario: Error is returned when schemas attribute is missing (HTTP PATCH)
	When execute HTTP PATCH JSON request 'http://localhost/Users/id'
	| Key | Value |

	And extract JSON from body

	Then HTTP status code equals to '400'
	Then JSON 'status'='400'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='400'
	Then JSON 'response.scimType'='invalidSyntax'
	Then JSON 'response.detail'='Request is unparsable, syntactically incorrect, or violates schema.'
	
Scenario: Error is returned when schema is not valid (HTTP PATCH)
	When execute HTTP PATCH JSON request 'http://localhost/Users/id'
	| Key		| Value					|
	| schemas	| [ "invalidschema" ]	|

	And extract JSON from body

	Then HTTP status code equals to '400'
	Then JSON 'status'='400'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='400'
	Then JSON 'response.scimType'='invalidSyntax'
	Then JSON 'response.detail'='Request is unparsable, syntactically incorrect, or violates schema.'

Scenario: Error is returned when trying to patch an unknown resource (HTTP PATCH)
	When execute HTTP PATCH JSON request 'http://localhost/Users/id'
	| Key        | Value                                               |
	| schemas    | [ "urn:ietf:params:scim:api:messages:2.0:PatchOp" ] |
	| Operations | [ ]                                                 |

	And extract JSON from body

	Then HTTP status code equals to '404'
	Then JSON 'status'='404'
	Then JSON 'response.schemas[0]'='urn:ietf:params:scim:api:messages:2.0:Error'
	Then JSON 'response.status'='404'
	Then JSON 'response.scimType'='notFound'
	Then JSON 'response.detail'='Resource does not exist'