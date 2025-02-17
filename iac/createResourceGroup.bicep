// common
targetScope = 'subscription'

// parameters
////////////////////////////////////////////////////////////////////////////////

param rgLocation string = 'northeurope'

param prefixHyphenated string = 'gravy-traders-prod'

// variables
////////////////////////////////////////////////////////////////////////////////

// rg for storage account, service bus, cosmos db & function app
var rgName = '${prefixHyphenated}-rg'

// tags
var rgTags = {
  Product: prefixHyphenated
  Environment: 'testing'
}

// resource groups
////////////////////////////////////////////////////////////////////////////////

resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: rgName
  location: rgLocation
  tags: rgTags
}

// outputs
////////////////////////////////////////////////////////////////////////////////

output outputRgName string = rg.name
