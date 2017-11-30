# TweakApi.Api.CustomerApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomersChangePasswordPost**](CustomerApi.md#customerschangepasswordpost) | **POST** /Customers/change-password | Change a user&#39;s password.
[**CustomersChangeStreamGet**](CustomerApi.md#customerschangestreamget) | **GET** /Customers/change-stream | Create a change stream.
[**CustomersChangeStreamPost**](CustomerApi.md#customerschangestreampost) | **POST** /Customers/change-stream | Create a change stream.
[**CustomersConfirmGet**](CustomerApi.md#customersconfirmget) | **GET** /Customers/confirm | Confirm a user registration with identity verification token.
[**CustomersCountGet**](CustomerApi.md#customerscountget) | **GET** /Customers/count | Count instances of the model matched by where from the data source.
[**CustomersEmailEmailExistsGet**](CustomerApi.md#customersemailemailexistsget) | **GET** /Customers/email/{email}/exists | Define whether customer exists or not
[**CustomersFindOneGet**](CustomerApi.md#customersfindoneget) | **GET** /Customers/findOne | Find first instance of the model matched by filter from the data source.
[**CustomersGet**](CustomerApi.md#customersget) | **GET** /Customers | Find all instances of the model matched by filter from the data source.
[**CustomersIdAccessTokensCountGet**](CustomerApi.md#customersidaccesstokenscountget) | **GET** /Customers/{id}/accessTokens/count | Counts accessTokens of Customer.
[**CustomersIdAccessTokensDelete**](CustomerApi.md#customersidaccesstokensdelete) | **DELETE** /Customers/{id}/accessTokens | Deletes all accessTokens of this model.
[**CustomersIdAccessTokensFkDelete**](CustomerApi.md#customersidaccesstokensfkdelete) | **DELETE** /Customers/{id}/accessTokens/{fk} | Delete a related item by id for accessTokens.
[**CustomersIdAccessTokensFkGet**](CustomerApi.md#customersidaccesstokensfkget) | **GET** /Customers/{id}/accessTokens/{fk} | Find a related item by id for accessTokens.
[**CustomersIdAccessTokensFkPut**](CustomerApi.md#customersidaccesstokensfkput) | **PUT** /Customers/{id}/accessTokens/{fk} | Update a related item by id for accessTokens.
[**CustomersIdAccessTokensGet**](CustomerApi.md#customersidaccesstokensget) | **GET** /Customers/{id}/accessTokens | Queries accessTokens of Customer.
[**CustomersIdAccessTokensPost**](CustomerApi.md#customersidaccesstokenspost) | **POST** /Customers/{id}/accessTokens | Creates a new instance in accessTokens of this model.
[**CustomersIdActiveGet**](CustomerApi.md#customersidactiveget) | **GET** /Customers/{id}/active | Define whether customer is active or not
[**CustomersIdDelete**](CustomerApi.md#customersiddelete) | **DELETE** /Customers/{id} | Delete a model instance by {{id}} from the data source.
[**CustomersIdExistsGet**](CustomerApi.md#customersidexistsget) | **GET** /Customers/{id}/exists | Check whether a model instance exists in the data source.
[**CustomersIdGet**](CustomerApi.md#customersidget) | **GET** /Customers/{id} | Find a model instance by {{id}} from the data source.
[**CustomersIdHead**](CustomerApi.md#customersidhead) | **HEAD** /Customers/{id} | Check whether a model instance exists in the data source.
[**CustomersIdInvitationTicketsCountGet**](CustomerApi.md#customersidinvitationticketscountget) | **GET** /Customers/{id}/invitationTickets/count | Counts invitationTickets of Customer.
[**CustomersIdInvitationTicketsDelete**](CustomerApi.md#customersidinvitationticketsdelete) | **DELETE** /Customers/{id}/invitationTickets | Deletes all invitationTickets of this model.
[**CustomersIdInvitationTicketsFkDelete**](CustomerApi.md#customersidinvitationticketsfkdelete) | **DELETE** /Customers/{id}/invitationTickets/{fk} | Delete a related item by id for invitationTickets.
[**CustomersIdInvitationTicketsFkGet**](CustomerApi.md#customersidinvitationticketsfkget) | **GET** /Customers/{id}/invitationTickets/{fk} | Find a related item by id for invitationTickets.
[**CustomersIdInvitationTicketsFkPut**](CustomerApi.md#customersidinvitationticketsfkput) | **PUT** /Customers/{id}/invitationTickets/{fk} | Update a related item by id for invitationTickets.
[**CustomersIdInvitationTicketsGet**](CustomerApi.md#customersidinvitationticketsget) | **GET** /Customers/{id}/invitationTickets | Queries invitationTickets of Customer.
[**CustomersIdInvitationTicketsPost**](CustomerApi.md#customersidinvitationticketspost) | **POST** /Customers/{id}/invitationTickets | Creates a new instance in invitationTickets of this model.
[**CustomersIdPatch**](CustomerApi.md#customersidpatch) | **PATCH** /Customers/{id} | Patch attributes for a model instance and persist it into the data source.
[**CustomersIdPermissionDelete**](CustomerApi.md#customersidpermissiondelete) | **DELETE** /Customers/{id}/permission | Deletes permission of this model.
[**CustomersIdPermissionGet**](CustomerApi.md#customersidpermissionget) | **GET** /Customers/{id}/permission | Fetches hasOne relation permission.
[**CustomersIdPermissionPost**](CustomerApi.md#customersidpermissionpost) | **POST** /Customers/{id}/permission | Creates a new instance in permission of this model.
[**CustomersIdPermissionPut**](CustomerApi.md#customersidpermissionput) | **PUT** /Customers/{id}/permission | Update permission of this model.
[**CustomersIdProfilePicturePut**](CustomerApi.md#customersidprofilepictureput) | **PUT** /Customers/{id}/profilePicture | Change profile picture
[**CustomersIdPut**](CustomerApi.md#customersidput) | **PUT** /Customers/{id} | Replace attributes for a model instance and persist it into the data source.
[**CustomersIdRegisterTeamPost**](CustomerApi.md#customersidregisterteampost) | **POST** /Customers/{id}/register/team | Register team and assign it to the customer
[**CustomersIdReplacePost**](CustomerApi.md#customersidreplacepost) | **POST** /Customers/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**CustomersIdTeamsCountGet**](CustomerApi.md#customersidteamscountget) | **GET** /Customers/{id}/teams/count | Counts teams of Customer.
[**CustomersIdTeamsDelete**](CustomerApi.md#customersidteamsdelete) | **DELETE** /Customers/{id}/teams | Deletes all teams of this model.
[**CustomersIdTeamsFkDelete**](CustomerApi.md#customersidteamsfkdelete) | **DELETE** /Customers/{id}/teams/{fk} | Delete a related item by id for teams.
[**CustomersIdTeamsFkGet**](CustomerApi.md#customersidteamsfkget) | **GET** /Customers/{id}/teams/{fk} | Find a related item by id for teams.
[**CustomersIdTeamsFkPut**](CustomerApi.md#customersidteamsfkput) | **PUT** /Customers/{id}/teams/{fk} | Update a related item by id for teams.
[**CustomersIdTeamsGet**](CustomerApi.md#customersidteamsget) | **GET** /Customers/{id}/teams | Queries teams of Customer.
[**CustomersIdTeamsNkBrandDelete**](CustomerApi.md#customersidteamsnkbranddelete) | **DELETE** /Customers/{id}/teams/{nk}/brand | Deletes brand of this model.
[**CustomersIdTeamsNkBrandGet**](CustomerApi.md#customersidteamsnkbrandget) | **GET** /Customers/{id}/teams/{nk}/brand | Fetches hasOne relation brand.
[**CustomersIdTeamsNkBrandPost**](CustomerApi.md#customersidteamsnkbrandpost) | **POST** /Customers/{id}/teams/{nk}/brand | Creates a new instance in brand of this model.
[**CustomersIdTeamsNkBrandPut**](CustomerApi.md#customersidteamsnkbrandput) | **PUT** /Customers/{id}/teams/{nk}/brand | Update brand of this model.
[**CustomersIdTeamsNkBuilderConfigsCountGet**](CustomerApi.md#customersidteamsnkbuilderconfigscountget) | **GET** /Customers/{id}/teams/{nk}/builderConfigs/count | Counts builderConfigs of Team.
[**CustomersIdTeamsNkBuilderConfigsDelete**](CustomerApi.md#customersidteamsnkbuilderconfigsdelete) | **DELETE** /Customers/{id}/teams/{nk}/builderConfigs | Deletes all builderConfigs of this model.
[**CustomersIdTeamsNkBuilderConfigsFkDelete**](CustomerApi.md#customersidteamsnkbuilderconfigsfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/builderConfigs/{fk} | Delete a related item by id for builderConfigs.
[**CustomersIdTeamsNkBuilderConfigsFkGet**](CustomerApi.md#customersidteamsnkbuilderconfigsfkget) | **GET** /Customers/{id}/teams/{nk}/builderConfigs/{fk} | Find a related item by id for builderConfigs.
[**CustomersIdTeamsNkBuilderConfigsFkPut**](CustomerApi.md#customersidteamsnkbuilderconfigsfkput) | **PUT** /Customers/{id}/teams/{nk}/builderConfigs/{fk} | Update a related item by id for builderConfigs.
[**CustomersIdTeamsNkBuilderConfigsGet**](CustomerApi.md#customersidteamsnkbuilderconfigsget) | **GET** /Customers/{id}/teams/{nk}/builderConfigs | Queries builderConfigs of Team.
[**CustomersIdTeamsNkBuilderConfigsPost**](CustomerApi.md#customersidteamsnkbuilderconfigspost) | **POST** /Customers/{id}/teams/{nk}/builderConfigs | Creates a new instance in builderConfigs of this model.
[**CustomersIdTeamsNkDataSourcesCountGet**](CustomerApi.md#customersidteamsnkdatasourcescountget) | **GET** /Customers/{id}/teams/{nk}/dataSources/count | Counts dataSources of Team.
[**CustomersIdTeamsNkDataSourcesDelete**](CustomerApi.md#customersidteamsnkdatasourcesdelete) | **DELETE** /Customers/{id}/teams/{nk}/dataSources | Deletes all dataSources of this model.
[**CustomersIdTeamsNkDataSourcesFkDelete**](CustomerApi.md#customersidteamsnkdatasourcesfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/dataSources/{fk} | Delete a related item by id for dataSources.
[**CustomersIdTeamsNkDataSourcesFkGet**](CustomerApi.md#customersidteamsnkdatasourcesfkget) | **GET** /Customers/{id}/teams/{nk}/dataSources/{fk} | Find a related item by id for dataSources.
[**CustomersIdTeamsNkDataSourcesFkPut**](CustomerApi.md#customersidteamsnkdatasourcesfkput) | **PUT** /Customers/{id}/teams/{nk}/dataSources/{fk} | Update a related item by id for dataSources.
[**CustomersIdTeamsNkDataSourcesGet**](CustomerApi.md#customersidteamsnkdatasourcesget) | **GET** /Customers/{id}/teams/{nk}/dataSources | Queries dataSources of Team.
[**CustomersIdTeamsNkDataSourcesPost**](CustomerApi.md#customersidteamsnkdatasourcespost) | **POST** /Customers/{id}/teams/{nk}/dataSources | Creates a new instance in dataSources of this model.
[**CustomersIdTeamsNkDynamicDatasCountGet**](CustomerApi.md#customersidteamsnkdynamicdatascountget) | **GET** /Customers/{id}/teams/{nk}/dynamicDatas/count | Counts dynamicDatas of Team.
[**CustomersIdTeamsNkDynamicDatasDelete**](CustomerApi.md#customersidteamsnkdynamicdatasdelete) | **DELETE** /Customers/{id}/teams/{nk}/dynamicDatas | Deletes all dynamicDatas of this model.
[**CustomersIdTeamsNkDynamicDatasFkDelete**](CustomerApi.md#customersidteamsnkdynamicdatasfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/dynamicDatas/{fk} | Delete a related item by id for dynamicDatas.
[**CustomersIdTeamsNkDynamicDatasFkGet**](CustomerApi.md#customersidteamsnkdynamicdatasfkget) | **GET** /Customers/{id}/teams/{nk}/dynamicDatas/{fk} | Find a related item by id for dynamicDatas.
[**CustomersIdTeamsNkDynamicDatasFkPut**](CustomerApi.md#customersidteamsnkdynamicdatasfkput) | **PUT** /Customers/{id}/teams/{nk}/dynamicDatas/{fk} | Update a related item by id for dynamicDatas.
[**CustomersIdTeamsNkDynamicDatasGet**](CustomerApi.md#customersidteamsnkdynamicdatasget) | **GET** /Customers/{id}/teams/{nk}/dynamicDatas | Queries dynamicDatas of Team.
[**CustomersIdTeamsNkDynamicDatasPost**](CustomerApi.md#customersidteamsnkdynamicdataspost) | **POST** /Customers/{id}/teams/{nk}/dynamicDatas | Creates a new instance in dynamicDatas of this model.
[**CustomersIdTeamsNkImageFoldersCountGet**](CustomerApi.md#customersidteamsnkimagefolderscountget) | **GET** /Customers/{id}/teams/{nk}/imageFolders/count | Counts imageFolders of Team.
[**CustomersIdTeamsNkImageFoldersDelete**](CustomerApi.md#customersidteamsnkimagefoldersdelete) | **DELETE** /Customers/{id}/teams/{nk}/imageFolders | Deletes all imageFolders of this model.
[**CustomersIdTeamsNkImageFoldersFkDelete**](CustomerApi.md#customersidteamsnkimagefoldersfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/imageFolders/{fk} | Delete a related item by id for imageFolders.
[**CustomersIdTeamsNkImageFoldersFkGet**](CustomerApi.md#customersidteamsnkimagefoldersfkget) | **GET** /Customers/{id}/teams/{nk}/imageFolders/{fk} | Find a related item by id for imageFolders.
[**CustomersIdTeamsNkImageFoldersFkPut**](CustomerApi.md#customersidteamsnkimagefoldersfkput) | **PUT** /Customers/{id}/teams/{nk}/imageFolders/{fk} | Update a related item by id for imageFolders.
[**CustomersIdTeamsNkImageFoldersGet**](CustomerApi.md#customersidteamsnkimagefoldersget) | **GET** /Customers/{id}/teams/{nk}/imageFolders | Queries imageFolders of Team.
[**CustomersIdTeamsNkImageFoldersPost**](CustomerApi.md#customersidteamsnkimagefolderspost) | **POST** /Customers/{id}/teams/{nk}/imageFolders | Creates a new instance in imageFolders of this model.
[**CustomersIdTeamsNkImagesCountGet**](CustomerApi.md#customersidteamsnkimagescountget) | **GET** /Customers/{id}/teams/{nk}/images/count | Counts images of Team.
[**CustomersIdTeamsNkImagesDelete**](CustomerApi.md#customersidteamsnkimagesdelete) | **DELETE** /Customers/{id}/teams/{nk}/images | Deletes all images of this model.
[**CustomersIdTeamsNkImagesFkDelete**](CustomerApi.md#customersidteamsnkimagesfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/images/{fk} | Delete a related item by id for images.
[**CustomersIdTeamsNkImagesFkGet**](CustomerApi.md#customersidteamsnkimagesfkget) | **GET** /Customers/{id}/teams/{nk}/images/{fk} | Find a related item by id for images.
[**CustomersIdTeamsNkImagesFkPut**](CustomerApi.md#customersidteamsnkimagesfkput) | **PUT** /Customers/{id}/teams/{nk}/images/{fk} | Update a related item by id for images.
[**CustomersIdTeamsNkImagesGet**](CustomerApi.md#customersidteamsnkimagesget) | **GET** /Customers/{id}/teams/{nk}/images | Queries images of Team.
[**CustomersIdTeamsNkImagesPost**](CustomerApi.md#customersidteamsnkimagespost) | **POST** /Customers/{id}/teams/{nk}/images | Creates a new instance in images of this model.
[**CustomersIdTeamsNkMembersCountGet**](CustomerApi.md#customersidteamsnkmemberscountget) | **GET** /Customers/{id}/teams/{nk}/members/count | Counts members of Team.
[**CustomersIdTeamsNkMembersDelete**](CustomerApi.md#customersidteamsnkmembersdelete) | **DELETE** /Customers/{id}/teams/{nk}/members | Deletes all members of this model.
[**CustomersIdTeamsNkMembersFkDelete**](CustomerApi.md#customersidteamsnkmembersfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/members/{fk} | Delete a related item by id for members.
[**CustomersIdTeamsNkMembersFkGet**](CustomerApi.md#customersidteamsnkmembersfkget) | **GET** /Customers/{id}/teams/{nk}/members/{fk} | Find a related item by id for members.
[**CustomersIdTeamsNkMembersFkPut**](CustomerApi.md#customersidteamsnkmembersfkput) | **PUT** /Customers/{id}/teams/{nk}/members/{fk} | Update a related item by id for members.
[**CustomersIdTeamsNkMembersGet**](CustomerApi.md#customersidteamsnkmembersget) | **GET** /Customers/{id}/teams/{nk}/members | Queries members of Team.
[**CustomersIdTeamsNkMembersPost**](CustomerApi.md#customersidteamsnkmemberspost) | **POST** /Customers/{id}/teams/{nk}/members | Creates a new instance in members of this model.
[**CustomersIdTeamsNkMembersRelFkDelete**](CustomerApi.md#customersidteamsnkmembersrelfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/members/rel/{fk} | Remove the members relation to an item by id.
[**CustomersIdTeamsNkMembersRelFkHead**](CustomerApi.md#customersidteamsnkmembersrelfkhead) | **HEAD** /Customers/{id}/teams/{nk}/members/rel/{fk} | Check the existence of members relation to an item by id.
[**CustomersIdTeamsNkMembersRelFkPut**](CustomerApi.md#customersidteamsnkmembersrelfkput) | **PUT** /Customers/{id}/teams/{nk}/members/rel/{fk} | Add a related item by id for members.
[**CustomersIdTeamsNkPermissionDelete**](CustomerApi.md#customersidteamsnkpermissiondelete) | **DELETE** /Customers/{id}/teams/{nk}/permission | Deletes permission of this model.
[**CustomersIdTeamsNkPermissionGet**](CustomerApi.md#customersidteamsnkpermissionget) | **GET** /Customers/{id}/teams/{nk}/permission | Fetches hasOne relation permission.
[**CustomersIdTeamsNkPermissionPost**](CustomerApi.md#customersidteamsnkpermissionpost) | **POST** /Customers/{id}/teams/{nk}/permission | Creates a new instance in permission of this model.
[**CustomersIdTeamsNkPermissionPut**](CustomerApi.md#customersidteamsnkpermissionput) | **PUT** /Customers/{id}/teams/{nk}/permission | Update permission of this model.
[**CustomersIdTeamsNkPortalsCountGet**](CustomerApi.md#customersidteamsnkportalscountget) | **GET** /Customers/{id}/teams/{nk}/portals/count | Counts portals of Team.
[**CustomersIdTeamsNkPortalsDelete**](CustomerApi.md#customersidteamsnkportalsdelete) | **DELETE** /Customers/{id}/teams/{nk}/portals | Deletes all portals of this model.
[**CustomersIdTeamsNkPortalsFkDelete**](CustomerApi.md#customersidteamsnkportalsfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/portals/{fk} | Delete a related item by id for portals.
[**CustomersIdTeamsNkPortalsFkGet**](CustomerApi.md#customersidteamsnkportalsfkget) | **GET** /Customers/{id}/teams/{nk}/portals/{fk} | Find a related item by id for portals.
[**CustomersIdTeamsNkPortalsFkPut**](CustomerApi.md#customersidteamsnkportalsfkput) | **PUT** /Customers/{id}/teams/{nk}/portals/{fk} | Update a related item by id for portals.
[**CustomersIdTeamsNkPortalsGet**](CustomerApi.md#customersidteamsnkportalsget) | **GET** /Customers/{id}/teams/{nk}/portals | Queries portals of Team.
[**CustomersIdTeamsNkPortalsPost**](CustomerApi.md#customersidteamsnkportalspost) | **POST** /Customers/{id}/teams/{nk}/portals | Creates a new instance in portals of this model.
[**CustomersIdTeamsNkProductMaterialsCountGet**](CustomerApi.md#customersidteamsnkproductmaterialscountget) | **GET** /Customers/{id}/teams/{nk}/productMaterials/count | Counts productMaterials of Team.
[**CustomersIdTeamsNkProductMaterialsDelete**](CustomerApi.md#customersidteamsnkproductmaterialsdelete) | **DELETE** /Customers/{id}/teams/{nk}/productMaterials | Deletes all productMaterials of this model.
[**CustomersIdTeamsNkProductMaterialsFkDelete**](CustomerApi.md#customersidteamsnkproductmaterialsfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/productMaterials/{fk} | Delete a related item by id for productMaterials.
[**CustomersIdTeamsNkProductMaterialsFkGet**](CustomerApi.md#customersidteamsnkproductmaterialsfkget) | **GET** /Customers/{id}/teams/{nk}/productMaterials/{fk} | Find a related item by id for productMaterials.
[**CustomersIdTeamsNkProductMaterialsFkPut**](CustomerApi.md#customersidteamsnkproductmaterialsfkput) | **PUT** /Customers/{id}/teams/{nk}/productMaterials/{fk} | Update a related item by id for productMaterials.
[**CustomersIdTeamsNkProductMaterialsGet**](CustomerApi.md#customersidteamsnkproductmaterialsget) | **GET** /Customers/{id}/teams/{nk}/productMaterials | Queries productMaterials of Team.
[**CustomersIdTeamsNkProductMaterialsPost**](CustomerApi.md#customersidteamsnkproductmaterialspost) | **POST** /Customers/{id}/teams/{nk}/productMaterials | Creates a new instance in productMaterials of this model.
[**CustomersIdTeamsNkProductPdfColorProfilesCountGet**](CustomerApi.md#customersidteamsnkproductpdfcolorprofilescountget) | **GET** /Customers/{id}/teams/{nk}/productPdfColorProfiles/count | Counts productPdfColorProfiles of Team.
[**CustomersIdTeamsNkProductPdfColorProfilesDelete**](CustomerApi.md#customersidteamsnkproductpdfcolorprofilesdelete) | **DELETE** /Customers/{id}/teams/{nk}/productPdfColorProfiles | Deletes all productPdfColorProfiles of this model.
[**CustomersIdTeamsNkProductPdfColorProfilesFkDelete**](CustomerApi.md#customersidteamsnkproductpdfcolorprofilesfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/productPdfColorProfiles/{fk} | Delete a related item by id for productPdfColorProfiles.
[**CustomersIdTeamsNkProductPdfColorProfilesFkGet**](CustomerApi.md#customersidteamsnkproductpdfcolorprofilesfkget) | **GET** /Customers/{id}/teams/{nk}/productPdfColorProfiles/{fk} | Find a related item by id for productPdfColorProfiles.
[**CustomersIdTeamsNkProductPdfColorProfilesFkPut**](CustomerApi.md#customersidteamsnkproductpdfcolorprofilesfkput) | **PUT** /Customers/{id}/teams/{nk}/productPdfColorProfiles/{fk} | Update a related item by id for productPdfColorProfiles.
[**CustomersIdTeamsNkProductPdfColorProfilesGet**](CustomerApi.md#customersidteamsnkproductpdfcolorprofilesget) | **GET** /Customers/{id}/teams/{nk}/productPdfColorProfiles | Queries productPdfColorProfiles of Team.
[**CustomersIdTeamsNkProductSizeMaterialsCountGet**](CustomerApi.md#customersidteamsnkproductsizematerialscountget) | **GET** /Customers/{id}/teams/{nk}/productSizeMaterials/count | Counts productSizeMaterials of Team.
[**CustomersIdTeamsNkProductSizeMaterialsDelete**](CustomerApi.md#customersidteamsnkproductsizematerialsdelete) | **DELETE** /Customers/{id}/teams/{nk}/productSizeMaterials | Deletes all productSizeMaterials of this model.
[**CustomersIdTeamsNkProductSizeMaterialsFkDelete**](CustomerApi.md#customersidteamsnkproductsizematerialsfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/productSizeMaterials/{fk} | Delete a related item by id for productSizeMaterials.
[**CustomersIdTeamsNkProductSizeMaterialsFkGet**](CustomerApi.md#customersidteamsnkproductsizematerialsfkget) | **GET** /Customers/{id}/teams/{nk}/productSizeMaterials/{fk} | Find a related item by id for productSizeMaterials.
[**CustomersIdTeamsNkProductSizeMaterialsFkPut**](CustomerApi.md#customersidteamsnkproductsizematerialsfkput) | **PUT** /Customers/{id}/teams/{nk}/productSizeMaterials/{fk} | Update a related item by id for productSizeMaterials.
[**CustomersIdTeamsNkProductSizeMaterialsGet**](CustomerApi.md#customersidteamsnkproductsizematerialsget) | **GET** /Customers/{id}/teams/{nk}/productSizeMaterials | Queries productSizeMaterials of Team.
[**CustomersIdTeamsNkProductSizeMaterialsPost**](CustomerApi.md#customersidteamsnkproductsizematerialspost) | **POST** /Customers/{id}/teams/{nk}/productSizeMaterials | Creates a new instance in productSizeMaterials of this model.
[**CustomersIdTeamsNkTeamDataGet**](CustomerApi.md#customersidteamsnkteamdataget) | **GET** /Customers/{id}/teams/{nk}/teamData | Fetches belongsTo relation teamData.
[**CustomersIdTeamsNkTeamMembersCountGet**](CustomerApi.md#customersidteamsnkteammemberscountget) | **GET** /Customers/{id}/teams/{nk}/teamMembers/count | Counts teamMembers of Team.
[**CustomersIdTeamsNkTeamMembersDelete**](CustomerApi.md#customersidteamsnkteammembersdelete) | **DELETE** /Customers/{id}/teams/{nk}/teamMembers | Deletes all teamMembers of this model.
[**CustomersIdTeamsNkTeamMembersFkDelete**](CustomerApi.md#customersidteamsnkteammembersfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/teamMembers/{fk} | Delete a related item by id for teamMembers.
[**CustomersIdTeamsNkTeamMembersFkGet**](CustomerApi.md#customersidteamsnkteammembersfkget) | **GET** /Customers/{id}/teams/{nk}/teamMembers/{fk} | Find a related item by id for teamMembers.
[**CustomersIdTeamsNkTeamMembersFkPut**](CustomerApi.md#customersidteamsnkteammembersfkput) | **PUT** /Customers/{id}/teams/{nk}/teamMembers/{fk} | Update a related item by id for teamMembers.
[**CustomersIdTeamsNkTeamMembersGet**](CustomerApi.md#customersidteamsnkteammembersget) | **GET** /Customers/{id}/teams/{nk}/teamMembers | Queries teamMembers of Team.
[**CustomersIdTeamsNkTeamMembersPost**](CustomerApi.md#customersidteamsnkteammemberspost) | **POST** /Customers/{id}/teams/{nk}/teamMembers | Creates a new instance in teamMembers of this model.
[**CustomersIdTeamsNkTemplateFoldersCountGet**](CustomerApi.md#customersidteamsnktemplatefolderscountget) | **GET** /Customers/{id}/teams/{nk}/templateFolders/count | Counts templateFolders of Team.
[**CustomersIdTeamsNkTemplateFoldersDelete**](CustomerApi.md#customersidteamsnktemplatefoldersdelete) | **DELETE** /Customers/{id}/teams/{nk}/templateFolders | Deletes all templateFolders of this model.
[**CustomersIdTeamsNkTemplateFoldersFkDelete**](CustomerApi.md#customersidteamsnktemplatefoldersfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/templateFolders/{fk} | Delete a related item by id for templateFolders.
[**CustomersIdTeamsNkTemplateFoldersFkGet**](CustomerApi.md#customersidteamsnktemplatefoldersfkget) | **GET** /Customers/{id}/teams/{nk}/templateFolders/{fk} | Find a related item by id for templateFolders.
[**CustomersIdTeamsNkTemplateFoldersFkPut**](CustomerApi.md#customersidteamsnktemplatefoldersfkput) | **PUT** /Customers/{id}/teams/{nk}/templateFolders/{fk} | Update a related item by id for templateFolders.
[**CustomersIdTeamsNkTemplateFoldersGet**](CustomerApi.md#customersidteamsnktemplatefoldersget) | **GET** /Customers/{id}/teams/{nk}/templateFolders | Queries templateFolders of Team.
[**CustomersIdTeamsNkTemplateFoldersPost**](CustomerApi.md#customersidteamsnktemplatefolderspost) | **POST** /Customers/{id}/teams/{nk}/templateFolders | Creates a new instance in templateFolders of this model.
[**CustomersIdTeamsNkTemplatesCountGet**](CustomerApi.md#customersidteamsnktemplatescountget) | **GET** /Customers/{id}/teams/{nk}/templates/count | Counts templates of Team.
[**CustomersIdTeamsNkTemplatesDelete**](CustomerApi.md#customersidteamsnktemplatesdelete) | **DELETE** /Customers/{id}/teams/{nk}/templates | Deletes all templates of this model.
[**CustomersIdTeamsNkTemplatesFkDelete**](CustomerApi.md#customersidteamsnktemplatesfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/templates/{fk} | Delete a related item by id for templates.
[**CustomersIdTeamsNkTemplatesFkGet**](CustomerApi.md#customersidteamsnktemplatesfkget) | **GET** /Customers/{id}/teams/{nk}/templates/{fk} | Find a related item by id for templates.
[**CustomersIdTeamsNkTemplatesFkPut**](CustomerApi.md#customersidteamsnktemplatesfkput) | **PUT** /Customers/{id}/teams/{nk}/templates/{fk} | Update a related item by id for templates.
[**CustomersIdTeamsNkTemplatesGet**](CustomerApi.md#customersidteamsnktemplatesget) | **GET** /Customers/{id}/teams/{nk}/templates | Queries templates of Team.
[**CustomersIdTeamsNkTemplatesPost**](CustomerApi.md#customersidteamsnktemplatespost) | **POST** /Customers/{id}/teams/{nk}/templates | Creates a new instance in templates of this model.
[**CustomersIdTeamsNkWorkflowsCountGet**](CustomerApi.md#customersidteamsnkworkflowscountget) | **GET** /Customers/{id}/teams/{nk}/workflows/count | Counts workflows of Team.
[**CustomersIdTeamsNkWorkflowsDelete**](CustomerApi.md#customersidteamsnkworkflowsdelete) | **DELETE** /Customers/{id}/teams/{nk}/workflows | Deletes all workflows of this model.
[**CustomersIdTeamsNkWorkflowsFkDelete**](CustomerApi.md#customersidteamsnkworkflowsfkdelete) | **DELETE** /Customers/{id}/teams/{nk}/workflows/{fk} | Delete a related item by id for workflows.
[**CustomersIdTeamsNkWorkflowsFkGet**](CustomerApi.md#customersidteamsnkworkflowsfkget) | **GET** /Customers/{id}/teams/{nk}/workflows/{fk} | Find a related item by id for workflows.
[**CustomersIdTeamsNkWorkflowsFkPut**](CustomerApi.md#customersidteamsnkworkflowsfkput) | **PUT** /Customers/{id}/teams/{nk}/workflows/{fk} | Update a related item by id for workflows.
[**CustomersIdTeamsNkWorkflowsGet**](CustomerApi.md#customersidteamsnkworkflowsget) | **GET** /Customers/{id}/teams/{nk}/workflows | Queries workflows of Team.
[**CustomersIdTeamsNkWorkflowsPost**](CustomerApi.md#customersidteamsnkworkflowspost) | **POST** /Customers/{id}/teams/{nk}/workflows | Creates a new instance in workflows of this model.
[**CustomersIdTeamsPost**](CustomerApi.md#customersidteamspost) | **POST** /Customers/{id}/teams | Creates a new instance in teams of this model.
[**CustomersIdTeamsRelFkDelete**](CustomerApi.md#customersidteamsrelfkdelete) | **DELETE** /Customers/{id}/teams/rel/{fk} | Remove the teams relation to an item by id.
[**CustomersIdTeamsRelFkHead**](CustomerApi.md#customersidteamsrelfkhead) | **HEAD** /Customers/{id}/teams/rel/{fk} | Check the existence of teams relation to an item by id.
[**CustomersIdTeamsRelFkPut**](CustomerApi.md#customersidteamsrelfkput) | **PUT** /Customers/{id}/teams/rel/{fk} | Add a related item by id for teams.
[**CustomersIdTeamsTeamIdChangePost**](CustomerApi.md#customersidteamsteamidchangepost) | **POST** /Customers/{id}/teams/{teamId}/change | Move authentication to a Team
[**CustomersIdTeamsTeamIdPortalsPortalIdChangePost**](CustomerApi.md#customersidteamsteamidportalsportalidchangepost) | **POST** /Customers/{id}/teams/{teamId}/portals/{portalId}/change | Move authentication to a Portal
[**CustomersIdTokenGet**](CustomerApi.md#customersidtokenget) | **GET** /Customers/{id}/token | Get token info
[**CustomersIdVerifyPost**](CustomerApi.md#customersidverifypost) | **POST** /Customers/{id}/verify | Trigger user&#39;s identity verification with configured verifyOptions
[**CustomersInvitationTicketsTokenAcceptPost**](CustomerApi.md#customersinvitationticketstokenacceptpost) | **POST** /Customers/invitationTickets/{token}/accept | Accept invitation with token
[**CustomersInvitationTicketsTokenGet**](CustomerApi.md#customersinvitationticketstokenget) | **GET** /Customers/invitationTickets/{token} | Get invitation details with token
[**CustomersLoginPost**](CustomerApi.md#customersloginpost) | **POST** /Customers/login | Login a user with username/email and password.
[**CustomersLogoutPost**](CustomerApi.md#customerslogoutpost) | **POST** /Customers/logout | Logout a user with access token.
[**CustomersMeTokenGet**](CustomerApi.md#customersmetokenget) | **GET** /Customers/me/token | Get token info
[**CustomersMeTokenRefreshGet**](CustomerApi.md#customersmetokenrefreshget) | **GET** /Customers/me/token/refresh | Refresh current access token
[**CustomersPatch**](CustomerApi.md#customerspatch) | **PATCH** /Customers | Patch an existing model instance or insert a new one into the data source.
[**CustomersPost**](CustomerApi.md#customerspost) | **POST** /Customers | Create a new instance of the model and persist it into the data source.
[**CustomersPut**](CustomerApi.md#customersput) | **PUT** /Customers | Replace an existing model instance or insert a new one into the data source.
[**CustomersRegisterPost**](CustomerApi.md#customersregisterpost) | **POST** /Customers/register | Create customer and assign it to a team
[**CustomersReplaceOrCreatePost**](CustomerApi.md#customersreplaceorcreatepost) | **POST** /Customers/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**CustomersResetPasswordPost**](CustomerApi.md#customersresetpasswordpost) | **POST** /Customers/reset-password | Reset user&#39;s password via a password-reset token.
[**CustomersResetPasswordTokenGet**](CustomerApi.md#customersresetpasswordtokenget) | **GET** /Customers/reset-password/token | Get token info for reset password token
[**CustomersResetPost**](CustomerApi.md#customersresetpost) | **POST** /Customers/reset | Reset password for a user with email.
[**CustomersUpdatePost**](CustomerApi.md#customersupdatepost) | **POST** /Customers/update | Update instances of the model matched by {{where}} from the data source.
[**CustomersUpsertWithWherePost**](CustomerApi.md#customersupsertwithwherepost) | **POST** /Customers/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="customerschangepasswordpost"></a>
# **CustomersChangePasswordPost**
> void CustomersChangePasswordPost (string oldPassword, string newPassword)

Change a user's password.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersChangePasswordPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var oldPassword = oldPassword_example;  // string | 
            var newPassword = newPassword_example;  // string | 

            try
            {
                // Change a user's password.
                apiInstance.CustomersChangePasswordPost(oldPassword, newPassword);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersChangePasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oldPassword** | **string**|  | 
 **newPassword** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerschangestreamget"></a>
# **CustomersChangeStreamGet**
> System.IO.Stream CustomersChangeStreamGet (string options = null)

Create a change stream.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.CustomersChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersChangeStreamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **options** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerschangestreampost"></a>
# **CustomersChangeStreamPost**
> System.IO.Stream CustomersChangeStreamPost (string options = null)

Create a change stream.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.CustomersChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersChangeStreamPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **options** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersconfirmget"></a>
# **CustomersConfirmGet**
> void CustomersConfirmGet (string uid, string token, string redirect = null)

Confirm a user registration with identity verification token.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersConfirmGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var uid = uid_example;  // string | 
            var token = token_example;  // string | 
            var redirect = redirect_example;  // string |  (optional) 

            try
            {
                // Confirm a user registration with identity verification token.
                apiInstance.CustomersConfirmGet(uid, token, redirect);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersConfirmGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uid** | **string**|  | 
 **token** | **string**|  | 
 **redirect** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerscountget"></a>
# **CustomersCountGet**
> InlineResponse200 CustomersCountGet (string where = null)

Count instances of the model matched by where from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.CustomersCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersemailemailexistsget"></a>
# **CustomersEmailEmailExistsGet**
> InlineResponse2001 CustomersEmailEmailExistsGet (string email)

Define whether customer exists or not

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersEmailEmailExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var email = email_example;  // string | Customer email

            try
            {
                // Define whether customer exists or not
                InlineResponse2001 result = apiInstance.CustomersEmailEmailExistsGet(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersEmailEmailExistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Customer email | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersfindoneget"></a>
# **CustomersFindOneGet**
> Customer CustomersFindOneGet (string filter = null)

Find first instance of the model matched by filter from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                Customer result = apiInstance.CustomersFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersFindOneGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersget"></a>
# **CustomersGet**
> List<Customer> CustomersGet (string filter = null)

Find all instances of the model matched by filter from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;Customer&gt; result = apiInstance.CustomersGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<Customer>**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidaccesstokenscountget"></a>
# **CustomersIdAccessTokensCountGet**
> InlineResponse200 CustomersIdAccessTokensCountGet (string id, string where = null)

Counts accessTokens of Customer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdAccessTokensCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts accessTokens of Customer.
                InlineResponse200 result = apiInstance.CustomersIdAccessTokensCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdAccessTokensCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidaccesstokensdelete"></a>
# **CustomersIdAccessTokensDelete**
> void CustomersIdAccessTokensDelete (string id)

Deletes all accessTokens of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdAccessTokensDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id

            try
            {
                // Deletes all accessTokens of this model.
                apiInstance.CustomersIdAccessTokensDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdAccessTokensDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidaccesstokensfkdelete"></a>
# **CustomersIdAccessTokensFkDelete**
> void CustomersIdAccessTokensFkDelete (string id, string fk)

Delete a related item by id for accessTokens.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdAccessTokensFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for accessTokens

            try
            {
                // Delete a related item by id for accessTokens.
                apiInstance.CustomersIdAccessTokensFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdAccessTokensFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for accessTokens | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidaccesstokensfkget"></a>
# **CustomersIdAccessTokensFkGet**
> TeamMemberAccessToken CustomersIdAccessTokensFkGet (string id, string fk)

Find a related item by id for accessTokens.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdAccessTokensFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for accessTokens

            try
            {
                // Find a related item by id for accessTokens.
                TeamMemberAccessToken result = apiInstance.CustomersIdAccessTokensFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdAccessTokensFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for accessTokens | 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidaccesstokensfkput"></a>
# **CustomersIdAccessTokensFkPut**
> TeamMemberAccessToken CustomersIdAccessTokensFkPut (string id, string fk, TeamMemberAccessToken data = null)

Update a related item by id for accessTokens.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdAccessTokensFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for accessTokens
            var data = new TeamMemberAccessToken(); // TeamMemberAccessToken |  (optional) 

            try
            {
                // Update a related item by id for accessTokens.
                TeamMemberAccessToken result = apiInstance.CustomersIdAccessTokensFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdAccessTokensFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for accessTokens | 
 **data** | [**TeamMemberAccessToken**](TeamMemberAccessToken.md)|  | [optional] 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidaccesstokensget"></a>
# **CustomersIdAccessTokensGet**
> List<TeamMemberAccessToken> CustomersIdAccessTokensGet (string id, string filter = null)

Queries accessTokens of Customer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdAccessTokensGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries accessTokens of Customer.
                List&lt;TeamMemberAccessToken&gt; result = apiInstance.CustomersIdAccessTokensGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdAccessTokensGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMemberAccessToken>**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidaccesstokenspost"></a>
# **CustomersIdAccessTokensPost**
> TeamMemberAccessToken CustomersIdAccessTokensPost (string id, TeamMemberAccessToken data = null)

Creates a new instance in accessTokens of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdAccessTokensPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var data = new TeamMemberAccessToken(); // TeamMemberAccessToken |  (optional) 

            try
            {
                // Creates a new instance in accessTokens of this model.
                TeamMemberAccessToken result = apiInstance.CustomersIdAccessTokensPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdAccessTokensPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **data** | [**TeamMemberAccessToken**](TeamMemberAccessToken.md)|  | [optional] 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidactiveget"></a>
# **CustomersIdActiveGet**
> InlineResponse2003 CustomersIdActiveGet (string id)

Define whether customer is active or not

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdActiveGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id or email

            try
            {
                // Define whether customer is active or not
                InlineResponse2003 result = apiInstance.CustomersIdActiveGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdActiveGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id or email | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersiddelete"></a>
# **CustomersIdDelete**
> Object CustomersIdDelete (string id)

Delete a model instance by {{id}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.CustomersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidexistsget"></a>
# **CustomersIdExistsGet**
> InlineResponse2001 CustomersIdExistsGet (string id)

Check whether a model instance exists in the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.CustomersIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdExistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidget"></a>
# **CustomersIdGet**
> Customer CustomersIdGet (string id, string filter = null)

Find a model instance by {{id}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                Customer result = apiInstance.CustomersIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidhead"></a>
# **CustomersIdHead**
> InlineResponse2001 CustomersIdHead (string id)

Check whether a model instance exists in the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.CustomersIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidinvitationticketscountget"></a>
# **CustomersIdInvitationTicketsCountGet**
> InlineResponse200 CustomersIdInvitationTicketsCountGet (string id, string where = null)

Counts invitationTickets of Customer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdInvitationTicketsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts invitationTickets of Customer.
                InlineResponse200 result = apiInstance.CustomersIdInvitationTicketsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdInvitationTicketsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidinvitationticketsdelete"></a>
# **CustomersIdInvitationTicketsDelete**
> void CustomersIdInvitationTicketsDelete (string id)

Deletes all invitationTickets of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdInvitationTicketsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id

            try
            {
                // Deletes all invitationTickets of this model.
                apiInstance.CustomersIdInvitationTicketsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdInvitationTicketsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidinvitationticketsfkdelete"></a>
# **CustomersIdInvitationTicketsFkDelete**
> void CustomersIdInvitationTicketsFkDelete (string id, string fk)

Delete a related item by id for invitationTickets.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdInvitationTicketsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for invitationTickets

            try
            {
                // Delete a related item by id for invitationTickets.
                apiInstance.CustomersIdInvitationTicketsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdInvitationTicketsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for invitationTickets | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidinvitationticketsfkget"></a>
# **CustomersIdInvitationTicketsFkGet**
> InvitationTicket CustomersIdInvitationTicketsFkGet (string id, string fk)

Find a related item by id for invitationTickets.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdInvitationTicketsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for invitationTickets

            try
            {
                // Find a related item by id for invitationTickets.
                InvitationTicket result = apiInstance.CustomersIdInvitationTicketsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdInvitationTicketsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for invitationTickets | 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidinvitationticketsfkput"></a>
# **CustomersIdInvitationTicketsFkPut**
> InvitationTicket CustomersIdInvitationTicketsFkPut (string id, string fk, InvitationTicket data = null)

Update a related item by id for invitationTickets.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdInvitationTicketsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for invitationTickets
            var data = new InvitationTicket(); // InvitationTicket |  (optional) 

            try
            {
                // Update a related item by id for invitationTickets.
                InvitationTicket result = apiInstance.CustomersIdInvitationTicketsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdInvitationTicketsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for invitationTickets | 
 **data** | [**InvitationTicket**](InvitationTicket.md)|  | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidinvitationticketsget"></a>
# **CustomersIdInvitationTicketsGet**
> List<InvitationTicket> CustomersIdInvitationTicketsGet (string id, string filter = null)

Queries invitationTickets of Customer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdInvitationTicketsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries invitationTickets of Customer.
                List&lt;InvitationTicket&gt; result = apiInstance.CustomersIdInvitationTicketsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdInvitationTicketsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<InvitationTicket>**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidinvitationticketspost"></a>
# **CustomersIdInvitationTicketsPost**
> InvitationTicket CustomersIdInvitationTicketsPost (string id, InvitationTicket data = null)

Creates a new instance in invitationTickets of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdInvitationTicketsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var data = new InvitationTicket(); // InvitationTicket |  (optional) 

            try
            {
                // Creates a new instance in invitationTickets of this model.
                InvitationTicket result = apiInstance.CustomersIdInvitationTicketsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdInvitationTicketsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **data** | [**InvitationTicket**](InvitationTicket.md)|  | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidpatch"></a>
# **CustomersIdPatch**
> Customer CustomersIdPatch (string id, Customer data = null)

Patch attributes for a model instance and persist it into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var data = new Customer(); // Customer | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                Customer result = apiInstance.CustomersIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **data** | [**Customer**](Customer.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidpermissiondelete"></a>
# **CustomersIdPermissionDelete**
> void CustomersIdPermissionDelete (string id)

Deletes permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdPermissionDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id

            try
            {
                // Deletes permission of this model.
                apiInstance.CustomersIdPermissionDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdPermissionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidpermissionget"></a>
# **CustomersIdPermissionGet**
> CustomerPermissionSet CustomersIdPermissionGet (string id, bool? refresh = null)

Fetches hasOne relation permission.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdPermissionGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation permission.
                CustomerPermissionSet result = apiInstance.CustomersIdPermissionGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdPermissionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**CustomerPermissionSet**](CustomerPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidpermissionpost"></a>
# **CustomersIdPermissionPost**
> CustomerPermissionSet CustomersIdPermissionPost (string id, CustomerPermissionSet data = null)

Creates a new instance in permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdPermissionPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var data = new CustomerPermissionSet(); // CustomerPermissionSet |  (optional) 

            try
            {
                // Creates a new instance in permission of this model.
                CustomerPermissionSet result = apiInstance.CustomersIdPermissionPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdPermissionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **data** | [**CustomerPermissionSet**](CustomerPermissionSet.md)|  | [optional] 

### Return type

[**CustomerPermissionSet**](CustomerPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidpermissionput"></a>
# **CustomersIdPermissionPut**
> CustomerPermissionSet CustomersIdPermissionPut (string id, CustomerPermissionSet data = null)

Update permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdPermissionPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var data = new CustomerPermissionSet(); // CustomerPermissionSet |  (optional) 

            try
            {
                // Update permission of this model.
                CustomerPermissionSet result = apiInstance.CustomersIdPermissionPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdPermissionPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **data** | [**CustomerPermissionSet**](CustomerPermissionSet.md)|  | [optional] 

### Return type

[**CustomerPermissionSet**](CustomerPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidprofilepictureput"></a>
# **CustomersIdProfilePicturePut**
> Customer CustomersIdProfilePicturePut (string id, string id2, Customer data)

Change profile picture

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdProfilePicturePutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var id2 = id_example;  // string | Customer id
            var data = new Customer(); // Customer | Profile picture

            try
            {
                // Change profile picture
                Customer result = apiInstance.CustomersIdProfilePicturePut(id, id2, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdProfilePicturePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **id2** | **string**| Customer id | 
 **data** | [**Customer**](Customer.md)| Profile picture | 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidput"></a>
# **CustomersIdPut**
> Customer CustomersIdPut (string id, Customer data = null)

Replace attributes for a model instance and persist it into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Model id
            var data = new Customer(); // Customer | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Customer result = apiInstance.CustomersIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Customer**](Customer.md)| Model instance data | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidregisterteampost"></a>
# **CustomersIdRegisterTeamPost**
> TeamMember CustomersIdRegisterTeamPost (string id, Team data = null)

Register team and assign it to the customer

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdRegisterTeamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var data = new Team(); // Team | Model instance data (optional) 

            try
            {
                // Register team and assign it to the customer
                TeamMember result = apiInstance.CustomersIdRegisterTeamPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdRegisterTeamPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **data** | [**Team**](Team.md)| Model instance data | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidreplacepost"></a>
# **CustomersIdReplacePost**
> Customer CustomersIdReplacePost (string id, Customer data = null)

Replace attributes for a model instance and persist it into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Model id
            var data = new Customer(); // Customer | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Customer result = apiInstance.CustomersIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Customer**](Customer.md)| Model instance data | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamscountget"></a>
# **CustomersIdTeamsCountGet**
> InlineResponse200 CustomersIdTeamsCountGet (string id, string where = null)

Counts teams of Customer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts teams of Customer.
                InlineResponse200 result = apiInstance.CustomersIdTeamsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsdelete"></a>
# **CustomersIdTeamsDelete**
> void CustomersIdTeamsDelete (string id)

Deletes all teams of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id

            try
            {
                // Deletes all teams of this model.
                apiInstance.CustomersIdTeamsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsfkdelete"></a>
# **CustomersIdTeamsFkDelete**
> void CustomersIdTeamsFkDelete (string id, string fk)

Delete a related item by id for teams.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for teams

            try
            {
                // Delete a related item by id for teams.
                apiInstance.CustomersIdTeamsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for teams | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsfkget"></a>
# **CustomersIdTeamsFkGet**
> Team CustomersIdTeamsFkGet (string id, string fk)

Find a related item by id for teams.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for teams

            try
            {
                // Find a related item by id for teams.
                Team result = apiInstance.CustomersIdTeamsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for teams | 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsfkput"></a>
# **CustomersIdTeamsFkPut**
> Team CustomersIdTeamsFkPut (string id, string fk, Team data = null)

Update a related item by id for teams.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for teams
            var data = new Team(); // Team |  (optional) 

            try
            {
                // Update a related item by id for teams.
                Team result = apiInstance.CustomersIdTeamsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for teams | 
 **data** | [**Team**](Team.md)|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsget"></a>
# **CustomersIdTeamsGet**
> List<Team> CustomersIdTeamsGet (string id, string filter = null)

Queries teams of Customer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries teams of Customer.
                List&lt;Team&gt; result = apiInstance.CustomersIdTeamsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbranddelete"></a>
# **CustomersIdTeamsNkBrandDelete**
> void CustomersIdTeamsNkBrandDelete (string id, string nk)

Deletes brand of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBrandDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes brand of this model.
                apiInstance.CustomersIdTeamsNkBrandDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBrandDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbrandget"></a>
# **CustomersIdTeamsNkBrandGet**
> TeamBrand CustomersIdTeamsNkBrandGet (string id, string nk, bool? refresh = null)

Fetches hasOne relation brand.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBrandGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation brand.
                TeamBrand result = apiInstance.CustomersIdTeamsNkBrandGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBrandGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbrandpost"></a>
# **CustomersIdTeamsNkBrandPost**
> TeamBrand CustomersIdTeamsNkBrandPost (string id, string nk, TeamBrand data = null)

Creates a new instance in brand of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBrandPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new TeamBrand(); // TeamBrand |  (optional) 

            try
            {
                // Creates a new instance in brand of this model.
                TeamBrand result = apiInstance.CustomersIdTeamsNkBrandPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBrandPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**TeamBrand**](TeamBrand.md)|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbrandput"></a>
# **CustomersIdTeamsNkBrandPut**
> TeamBrand CustomersIdTeamsNkBrandPut (string id, string nk, TeamBrand data = null)

Update brand of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBrandPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new TeamBrand(); // TeamBrand |  (optional) 

            try
            {
                // Update brand of this model.
                TeamBrand result = apiInstance.CustomersIdTeamsNkBrandPut(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBrandPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**TeamBrand**](TeamBrand.md)|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbuilderconfigscountget"></a>
# **CustomersIdTeamsNkBuilderConfigsCountGet**
> InlineResponse200 CustomersIdTeamsNkBuilderConfigsCountGet (string id, string nk, string where = null)

Counts builderConfigs of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBuilderConfigsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts builderConfigs of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkBuilderConfigsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBuilderConfigsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbuilderconfigsdelete"></a>
# **CustomersIdTeamsNkBuilderConfigsDelete**
> void CustomersIdTeamsNkBuilderConfigsDelete (string id, string nk)

Deletes all builderConfigs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBuilderConfigsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all builderConfigs of this model.
                apiInstance.CustomersIdTeamsNkBuilderConfigsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBuilderConfigsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbuilderconfigsfkdelete"></a>
# **CustomersIdTeamsNkBuilderConfigsFkDelete**
> void CustomersIdTeamsNkBuilderConfigsFkDelete (string id, string nk, string fk)

Delete a related item by id for builderConfigs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBuilderConfigsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for builderConfigs

            try
            {
                // Delete a related item by id for builderConfigs.
                apiInstance.CustomersIdTeamsNkBuilderConfigsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBuilderConfigsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for builderConfigs | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbuilderconfigsfkget"></a>
# **CustomersIdTeamsNkBuilderConfigsFkGet**
> TeamBuilderConfig CustomersIdTeamsNkBuilderConfigsFkGet (string id, string nk, string fk)

Find a related item by id for builderConfigs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBuilderConfigsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for builderConfigs

            try
            {
                // Find a related item by id for builderConfigs.
                TeamBuilderConfig result = apiInstance.CustomersIdTeamsNkBuilderConfigsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBuilderConfigsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for builderConfigs | 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbuilderconfigsfkput"></a>
# **CustomersIdTeamsNkBuilderConfigsFkPut**
> TeamBuilderConfig CustomersIdTeamsNkBuilderConfigsFkPut (string id, string nk, string fk, TeamBuilderConfig data = null)

Update a related item by id for builderConfigs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBuilderConfigsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for builderConfigs
            var data = new TeamBuilderConfig(); // TeamBuilderConfig |  (optional) 

            try
            {
                // Update a related item by id for builderConfigs.
                TeamBuilderConfig result = apiInstance.CustomersIdTeamsNkBuilderConfigsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBuilderConfigsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for builderConfigs | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)|  | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbuilderconfigsget"></a>
# **CustomersIdTeamsNkBuilderConfigsGet**
> List<TeamBuilderConfig> CustomersIdTeamsNkBuilderConfigsGet (string id, string nk, string filter = null)

Queries builderConfigs of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBuilderConfigsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries builderConfigs of Team.
                List&lt;TeamBuilderConfig&gt; result = apiInstance.CustomersIdTeamsNkBuilderConfigsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBuilderConfigsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamBuilderConfig>**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkbuilderconfigspost"></a>
# **CustomersIdTeamsNkBuilderConfigsPost**
> TeamBuilderConfig CustomersIdTeamsNkBuilderConfigsPost (string id, string nk, TeamBuilderConfig data = null)

Creates a new instance in builderConfigs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkBuilderConfigsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new TeamBuilderConfig(); // TeamBuilderConfig |  (optional) 

            try
            {
                // Creates a new instance in builderConfigs of this model.
                TeamBuilderConfig result = apiInstance.CustomersIdTeamsNkBuilderConfigsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkBuilderConfigsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)|  | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdatasourcescountget"></a>
# **CustomersIdTeamsNkDataSourcesCountGet**
> InlineResponse200 CustomersIdTeamsNkDataSourcesCountGet (string id, string nk, string where = null)

Counts dataSources of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDataSourcesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts dataSources of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkDataSourcesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDataSourcesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdatasourcesdelete"></a>
# **CustomersIdTeamsNkDataSourcesDelete**
> void CustomersIdTeamsNkDataSourcesDelete (string id, string nk)

Deletes all dataSources of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDataSourcesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all dataSources of this model.
                apiInstance.CustomersIdTeamsNkDataSourcesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDataSourcesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdatasourcesfkdelete"></a>
# **CustomersIdTeamsNkDataSourcesFkDelete**
> void CustomersIdTeamsNkDataSourcesFkDelete (string id, string nk, string fk)

Delete a related item by id for dataSources.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDataSourcesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for dataSources

            try
            {
                // Delete a related item by id for dataSources.
                apiInstance.CustomersIdTeamsNkDataSourcesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDataSourcesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for dataSources | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdatasourcesfkget"></a>
# **CustomersIdTeamsNkDataSourcesFkGet**
> DataSource CustomersIdTeamsNkDataSourcesFkGet (string id, string nk, string fk)

Find a related item by id for dataSources.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDataSourcesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for dataSources

            try
            {
                // Find a related item by id for dataSources.
                DataSource result = apiInstance.CustomersIdTeamsNkDataSourcesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDataSourcesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for dataSources | 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdatasourcesfkput"></a>
# **CustomersIdTeamsNkDataSourcesFkPut**
> DataSource CustomersIdTeamsNkDataSourcesFkPut (string id, string nk, string fk, DataSource data = null)

Update a related item by id for dataSources.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDataSourcesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for dataSources
            var data = new DataSource(); // DataSource |  (optional) 

            try
            {
                // Update a related item by id for dataSources.
                DataSource result = apiInstance.CustomersIdTeamsNkDataSourcesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDataSourcesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for dataSources | 
 **data** | [**DataSource**](DataSource.md)|  | [optional] 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdatasourcesget"></a>
# **CustomersIdTeamsNkDataSourcesGet**
> List<DataSource> CustomersIdTeamsNkDataSourcesGet (string id, string nk, string filter = null)

Queries dataSources of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDataSourcesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries dataSources of Team.
                List&lt;DataSource&gt; result = apiInstance.CustomersIdTeamsNkDataSourcesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDataSourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DataSource>**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdatasourcespost"></a>
# **CustomersIdTeamsNkDataSourcesPost**
> DataSource CustomersIdTeamsNkDataSourcesPost (string id, string nk, DataSource data = null)

Creates a new instance in dataSources of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDataSourcesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new DataSource(); // DataSource |  (optional) 

            try
            {
                // Creates a new instance in dataSources of this model.
                DataSource result = apiInstance.CustomersIdTeamsNkDataSourcesPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDataSourcesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**DataSource**](DataSource.md)|  | [optional] 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdynamicdatascountget"></a>
# **CustomersIdTeamsNkDynamicDatasCountGet**
> InlineResponse200 CustomersIdTeamsNkDynamicDatasCountGet (string id, string nk, string where = null)

Counts dynamicDatas of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDynamicDatasCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts dynamicDatas of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkDynamicDatasCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDynamicDatasCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdynamicdatasdelete"></a>
# **CustomersIdTeamsNkDynamicDatasDelete**
> void CustomersIdTeamsNkDynamicDatasDelete (string id, string nk)

Deletes all dynamicDatas of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDynamicDatasDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all dynamicDatas of this model.
                apiInstance.CustomersIdTeamsNkDynamicDatasDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDynamicDatasDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdynamicdatasfkdelete"></a>
# **CustomersIdTeamsNkDynamicDatasFkDelete**
> void CustomersIdTeamsNkDynamicDatasFkDelete (string id, string nk, string fk)

Delete a related item by id for dynamicDatas.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDynamicDatasFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Delete a related item by id for dynamicDatas.
                apiInstance.CustomersIdTeamsNkDynamicDatasFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDynamicDatasFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdynamicdatasfkget"></a>
# **CustomersIdTeamsNkDynamicDatasFkGet**
> DynamicData CustomersIdTeamsNkDynamicDatasFkGet (string id, string nk, string fk)

Find a related item by id for dynamicDatas.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDynamicDatasFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Find a related item by id for dynamicDatas.
                DynamicData result = apiInstance.CustomersIdTeamsNkDynamicDatasFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDynamicDatasFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdynamicdatasfkput"></a>
# **CustomersIdTeamsNkDynamicDatasFkPut**
> DynamicData CustomersIdTeamsNkDynamicDatasFkPut (string id, string nk, string fk, DynamicData data = null)

Update a related item by id for dynamicDatas.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDynamicDatasFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for dynamicDatas
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Update a related item by id for dynamicDatas.
                DynamicData result = apiInstance.CustomersIdTeamsNkDynamicDatasFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDynamicDatasFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for dynamicDatas | 
 **data** | [**DynamicData**](DynamicData.md)|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdynamicdatasget"></a>
# **CustomersIdTeamsNkDynamicDatasGet**
> List<DynamicData> CustomersIdTeamsNkDynamicDatasGet (string id, string nk, string filter = null)

Queries dynamicDatas of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDynamicDatasGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries dynamicDatas of Team.
                List&lt;DynamicData&gt; result = apiInstance.CustomersIdTeamsNkDynamicDatasGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDynamicDatasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DynamicData>**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkdynamicdataspost"></a>
# **CustomersIdTeamsNkDynamicDatasPost**
> DynamicData CustomersIdTeamsNkDynamicDatasPost (string id, string nk, DynamicData data = null)

Creates a new instance in dynamicDatas of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkDynamicDatasPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Creates a new instance in dynamicDatas of this model.
                DynamicData result = apiInstance.CustomersIdTeamsNkDynamicDatasPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkDynamicDatasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**DynamicData**](DynamicData.md)|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagefolderscountget"></a>
# **CustomersIdTeamsNkImageFoldersCountGet**
> InlineResponse200 CustomersIdTeamsNkImageFoldersCountGet (string id, string nk, string where = null)

Counts imageFolders of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImageFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts imageFolders of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkImageFoldersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImageFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagefoldersdelete"></a>
# **CustomersIdTeamsNkImageFoldersDelete**
> void CustomersIdTeamsNkImageFoldersDelete (string id, string nk)

Deletes all imageFolders of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImageFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all imageFolders of this model.
                apiInstance.CustomersIdTeamsNkImageFoldersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImageFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagefoldersfkdelete"></a>
# **CustomersIdTeamsNkImageFoldersFkDelete**
> void CustomersIdTeamsNkImageFoldersFkDelete (string id, string nk, string fk)

Delete a related item by id for imageFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImageFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Delete a related item by id for imageFolders.
                apiInstance.CustomersIdTeamsNkImageFoldersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImageFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagefoldersfkget"></a>
# **CustomersIdTeamsNkImageFoldersFkGet**
> ImageFolder CustomersIdTeamsNkImageFoldersFkGet (string id, string nk, string fk)

Find a related item by id for imageFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImageFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Find a related item by id for imageFolders.
                ImageFolder result = apiInstance.CustomersIdTeamsNkImageFoldersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImageFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagefoldersfkput"></a>
# **CustomersIdTeamsNkImageFoldersFkPut**
> ImageFolder CustomersIdTeamsNkImageFoldersFkPut (string id, string nk, string fk, ImageFolder data = null)

Update a related item by id for imageFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImageFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Update a related item by id for imageFolders.
                ImageFolder result = apiInstance.CustomersIdTeamsNkImageFoldersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImageFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for imageFolders | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagefoldersget"></a>
# **CustomersIdTeamsNkImageFoldersGet**
> List<ImageFolder> CustomersIdTeamsNkImageFoldersGet (string id, string nk, string filter = null)

Queries imageFolders of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImageFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries imageFolders of Team.
                List&lt;ImageFolder&gt; result = apiInstance.CustomersIdTeamsNkImageFoldersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImageFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ImageFolder>**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagefolderspost"></a>
# **CustomersIdTeamsNkImageFoldersPost**
> ImageFolder CustomersIdTeamsNkImageFoldersPost (string id, string nk, ImageFolder data = null)

Creates a new instance in imageFolders of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImageFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Creates a new instance in imageFolders of this model.
                ImageFolder result = apiInstance.CustomersIdTeamsNkImageFoldersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImageFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagescountget"></a>
# **CustomersIdTeamsNkImagesCountGet**
> InlineResponse200 CustomersIdTeamsNkImagesCountGet (string id, string nk, string where = null)

Counts images of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImagesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts images of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkImagesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImagesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagesdelete"></a>
# **CustomersIdTeamsNkImagesDelete**
> void CustomersIdTeamsNkImagesDelete (string id, string nk)

Deletes all images of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImagesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all images of this model.
                apiInstance.CustomersIdTeamsNkImagesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImagesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagesfkdelete"></a>
# **CustomersIdTeamsNkImagesFkDelete**
> void CustomersIdTeamsNkImagesFkDelete (string id, string nk, string fk)

Delete a related item by id for images.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImagesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for images

            try
            {
                // Delete a related item by id for images.
                apiInstance.CustomersIdTeamsNkImagesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImagesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for images | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagesfkget"></a>
# **CustomersIdTeamsNkImagesFkGet**
> Image CustomersIdTeamsNkImagesFkGet (string id, string nk, string fk)

Find a related item by id for images.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImagesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for images

            try
            {
                // Find a related item by id for images.
                Image result = apiInstance.CustomersIdTeamsNkImagesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImagesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for images | 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagesfkput"></a>
# **CustomersIdTeamsNkImagesFkPut**
> Image CustomersIdTeamsNkImagesFkPut (string id, string nk, string fk, Image data = null)

Update a related item by id for images.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImagesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for images
            var data = new Image(); // Image |  (optional) 

            try
            {
                // Update a related item by id for images.
                Image result = apiInstance.CustomersIdTeamsNkImagesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImagesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for images | 
 **data** | [**Image**](Image.md)|  | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagesget"></a>
# **CustomersIdTeamsNkImagesGet**
> List<Image> CustomersIdTeamsNkImagesGet (string id, string nk, string filter = null)

Queries images of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImagesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries images of Team.
                List&lt;Image&gt; result = apiInstance.CustomersIdTeamsNkImagesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Image>**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkimagespost"></a>
# **CustomersIdTeamsNkImagesPost**
> Image CustomersIdTeamsNkImagesPost (string id, string nk, Image data = null)

Creates a new instance in images of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkImagesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new Image(); // Image |  (optional) 

            try
            {
                // Creates a new instance in images of this model.
                Image result = apiInstance.CustomersIdTeamsNkImagesPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkImagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**Image**](Image.md)|  | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmemberscountget"></a>
# **CustomersIdTeamsNkMembersCountGet**
> InlineResponse200 CustomersIdTeamsNkMembersCountGet (string id, string nk, string where = null)

Counts members of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts members of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkMembersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmembersdelete"></a>
# **CustomersIdTeamsNkMembersDelete**
> void CustomersIdTeamsNkMembersDelete (string id, string nk)

Deletes all members of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all members of this model.
                apiInstance.CustomersIdTeamsNkMembersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmembersfkdelete"></a>
# **CustomersIdTeamsNkMembersFkDelete**
> void CustomersIdTeamsNkMembersFkDelete (string id, string nk, string fk)

Delete a related item by id for members.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Delete a related item by id for members.
                apiInstance.CustomersIdTeamsNkMembersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmembersfkget"></a>
# **CustomersIdTeamsNkMembersFkGet**
> Customer CustomersIdTeamsNkMembersFkGet (string id, string nk, string fk)

Find a related item by id for members.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Find a related item by id for members.
                Customer result = apiInstance.CustomersIdTeamsNkMembersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for members | 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmembersfkput"></a>
# **CustomersIdTeamsNkMembersFkPut**
> Customer CustomersIdTeamsNkMembersFkPut (string id, string nk, string fk, Customer data = null)

Update a related item by id for members.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for members
            var data = new Customer(); // Customer |  (optional) 

            try
            {
                // Update a related item by id for members.
                Customer result = apiInstance.CustomersIdTeamsNkMembersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for members | 
 **data** | [**Customer**](Customer.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmembersget"></a>
# **CustomersIdTeamsNkMembersGet**
> List<Customer> CustomersIdTeamsNkMembersGet (string id, string nk, string filter = null)

Queries members of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries members of Team.
                List&lt;Customer&gt; result = apiInstance.CustomersIdTeamsNkMembersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Customer>**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmemberspost"></a>
# **CustomersIdTeamsNkMembersPost**
> Customer CustomersIdTeamsNkMembersPost (string id, string nk, Customer data = null)

Creates a new instance in members of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new Customer(); // Customer |  (optional) 

            try
            {
                // Creates a new instance in members of this model.
                Customer result = apiInstance.CustomersIdTeamsNkMembersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**Customer**](Customer.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmembersrelfkdelete"></a>
# **CustomersIdTeamsNkMembersRelFkDelete**
> void CustomersIdTeamsNkMembersRelFkDelete (string id, string nk, string fk)

Remove the members relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Remove the members relation to an item by id.
                apiInstance.CustomersIdTeamsNkMembersRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmembersrelfkhead"></a>
# **CustomersIdTeamsNkMembersRelFkHead**
> bool? CustomersIdTeamsNkMembersRelFkHead (string id, string nk, string fk)

Check the existence of members relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Check the existence of members relation to an item by id.
                bool? result = apiInstance.CustomersIdTeamsNkMembersRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for members | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkmembersrelfkput"></a>
# **CustomersIdTeamsNkMembersRelFkPut**
> TeamMember CustomersIdTeamsNkMembersRelFkPut (string id, string nk, string fk, TeamMember data = null)

Add a related item by id for members.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkMembersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for members
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Add a related item by id for members.
                TeamMember result = apiInstance.CustomersIdTeamsNkMembersRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkMembersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for members | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkpermissiondelete"></a>
# **CustomersIdTeamsNkPermissionDelete**
> void CustomersIdTeamsNkPermissionDelete (string id, string nk)

Deletes permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPermissionDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes permission of this model.
                apiInstance.CustomersIdTeamsNkPermissionDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPermissionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkpermissionget"></a>
# **CustomersIdTeamsNkPermissionGet**
> TeamPermissionSet CustomersIdTeamsNkPermissionGet (string id, string nk, bool? refresh = null)

Fetches hasOne relation permission.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPermissionGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation permission.
                TeamPermissionSet result = apiInstance.CustomersIdTeamsNkPermissionGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPermissionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkpermissionpost"></a>
# **CustomersIdTeamsNkPermissionPost**
> TeamPermissionSet CustomersIdTeamsNkPermissionPost (string id, string nk, TeamPermissionSet data = null)

Creates a new instance in permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPermissionPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new TeamPermissionSet(); // TeamPermissionSet |  (optional) 

            try
            {
                // Creates a new instance in permission of this model.
                TeamPermissionSet result = apiInstance.CustomersIdTeamsNkPermissionPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPermissionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkpermissionput"></a>
# **CustomersIdTeamsNkPermissionPut**
> TeamPermissionSet CustomersIdTeamsNkPermissionPut (string id, string nk, TeamPermissionSet data = null)

Update permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPermissionPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new TeamPermissionSet(); // TeamPermissionSet |  (optional) 

            try
            {
                // Update permission of this model.
                TeamPermissionSet result = apiInstance.CustomersIdTeamsNkPermissionPut(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPermissionPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkportalscountget"></a>
# **CustomersIdTeamsNkPortalsCountGet**
> InlineResponse200 CustomersIdTeamsNkPortalsCountGet (string id, string nk, string where = null)

Counts portals of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPortalsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portals of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkPortalsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPortalsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkportalsdelete"></a>
# **CustomersIdTeamsNkPortalsDelete**
> void CustomersIdTeamsNkPortalsDelete (string id, string nk)

Deletes all portals of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPortalsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all portals of this model.
                apiInstance.CustomersIdTeamsNkPortalsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPortalsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkportalsfkdelete"></a>
# **CustomersIdTeamsNkPortalsFkDelete**
> void CustomersIdTeamsNkPortalsFkDelete (string id, string nk, string fk)

Delete a related item by id for portals.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPortalsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Delete a related item by id for portals.
                apiInstance.CustomersIdTeamsNkPortalsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPortalsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkportalsfkget"></a>
# **CustomersIdTeamsNkPortalsFkGet**
> Portal CustomersIdTeamsNkPortalsFkGet (string id, string nk, string fk)

Find a related item by id for portals.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPortalsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Find a related item by id for portals.
                Portal result = apiInstance.CustomersIdTeamsNkPortalsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPortalsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkportalsfkput"></a>
# **CustomersIdTeamsNkPortalsFkPut**
> Portal CustomersIdTeamsNkPortalsFkPut (string id, string nk, string fk, Portal data = null)

Update a related item by id for portals.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPortalsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for portals
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Update a related item by id for portals.
                Portal result = apiInstance.CustomersIdTeamsNkPortalsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPortalsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for portals | 
 **data** | [**Portal**](Portal.md)|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkportalsget"></a>
# **CustomersIdTeamsNkPortalsGet**
> List<Portal> CustomersIdTeamsNkPortalsGet (string id, string nk, string filter = null)

Queries portals of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPortalsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portals of Team.
                List&lt;Portal&gt; result = apiInstance.CustomersIdTeamsNkPortalsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPortalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Portal>**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkportalspost"></a>
# **CustomersIdTeamsNkPortalsPost**
> Portal CustomersIdTeamsNkPortalsPost (string id, string nk, Portal data = null)

Creates a new instance in portals of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkPortalsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Creates a new instance in portals of this model.
                Portal result = apiInstance.CustomersIdTeamsNkPortalsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkPortalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**Portal**](Portal.md)|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductmaterialscountget"></a>
# **CustomersIdTeamsNkProductMaterialsCountGet**
> InlineResponse200 CustomersIdTeamsNkProductMaterialsCountGet (string id, string nk, string where = null)

Counts productMaterials of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productMaterials of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkProductMaterialsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductmaterialsdelete"></a>
# **CustomersIdTeamsNkProductMaterialsDelete**
> void CustomersIdTeamsNkProductMaterialsDelete (string id, string nk)

Deletes all productMaterials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all productMaterials of this model.
                apiInstance.CustomersIdTeamsNkProductMaterialsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductmaterialsfkdelete"></a>
# **CustomersIdTeamsNkProductMaterialsFkDelete**
> void CustomersIdTeamsNkProductMaterialsFkDelete (string id, string nk, string fk)

Delete a related item by id for productMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productMaterials

            try
            {
                // Delete a related item by id for productMaterials.
                apiInstance.CustomersIdTeamsNkProductMaterialsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productMaterials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductmaterialsfkget"></a>
# **CustomersIdTeamsNkProductMaterialsFkGet**
> ProductMaterial CustomersIdTeamsNkProductMaterialsFkGet (string id, string nk, string fk)

Find a related item by id for productMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productMaterials

            try
            {
                // Find a related item by id for productMaterials.
                ProductMaterial result = apiInstance.CustomersIdTeamsNkProductMaterialsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productMaterials | 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductmaterialsfkput"></a>
# **CustomersIdTeamsNkProductMaterialsFkPut**
> ProductMaterial CustomersIdTeamsNkProductMaterialsFkPut (string id, string nk, string fk, ProductMaterial data = null)

Update a related item by id for productMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productMaterials
            var data = new ProductMaterial(); // ProductMaterial |  (optional) 

            try
            {
                // Update a related item by id for productMaterials.
                ProductMaterial result = apiInstance.CustomersIdTeamsNkProductMaterialsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productMaterials | 
 **data** | [**ProductMaterial**](ProductMaterial.md)|  | [optional] 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductmaterialsget"></a>
# **CustomersIdTeamsNkProductMaterialsGet**
> List<ProductMaterial> CustomersIdTeamsNkProductMaterialsGet (string id, string nk, string filter = null)

Queries productMaterials of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productMaterials of Team.
                List&lt;ProductMaterial&gt; result = apiInstance.CustomersIdTeamsNkProductMaterialsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductMaterial>**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductmaterialspost"></a>
# **CustomersIdTeamsNkProductMaterialsPost**
> ProductMaterial CustomersIdTeamsNkProductMaterialsPost (string id, string nk, ProductMaterial data = null)

Creates a new instance in productMaterials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new ProductMaterial(); // ProductMaterial |  (optional) 

            try
            {
                // Creates a new instance in productMaterials of this model.
                ProductMaterial result = apiInstance.CustomersIdTeamsNkProductMaterialsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**ProductMaterial**](ProductMaterial.md)|  | [optional] 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductpdfcolorprofilescountget"></a>
# **CustomersIdTeamsNkProductPdfColorProfilesCountGet**
> InlineResponse200 CustomersIdTeamsNkProductPdfColorProfilesCountGet (string id, string nk, string where = null)

Counts productPdfColorProfiles of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductPdfColorProfilesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productPdfColorProfiles of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkProductPdfColorProfilesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductPdfColorProfilesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductpdfcolorprofilesdelete"></a>
# **CustomersIdTeamsNkProductPdfColorProfilesDelete**
> void CustomersIdTeamsNkProductPdfColorProfilesDelete (string id, string nk)

Deletes all productPdfColorProfiles of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductPdfColorProfilesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all productPdfColorProfiles of this model.
                apiInstance.CustomersIdTeamsNkProductPdfColorProfilesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductPdfColorProfilesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductpdfcolorprofilesfkdelete"></a>
# **CustomersIdTeamsNkProductPdfColorProfilesFkDelete**
> void CustomersIdTeamsNkProductPdfColorProfilesFkDelete (string id, string nk, string fk)

Delete a related item by id for productPdfColorProfiles.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductPdfColorProfilesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productPdfColorProfiles

            try
            {
                // Delete a related item by id for productPdfColorProfiles.
                apiInstance.CustomersIdTeamsNkProductPdfColorProfilesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductPdfColorProfilesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productPdfColorProfiles | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductpdfcolorprofilesfkget"></a>
# **CustomersIdTeamsNkProductPdfColorProfilesFkGet**
> ProductPdfColorProfile CustomersIdTeamsNkProductPdfColorProfilesFkGet (string id, string nk, string fk)

Find a related item by id for productPdfColorProfiles.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductPdfColorProfilesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productPdfColorProfiles

            try
            {
                // Find a related item by id for productPdfColorProfiles.
                ProductPdfColorProfile result = apiInstance.CustomersIdTeamsNkProductPdfColorProfilesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductPdfColorProfilesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productPdfColorProfiles | 

### Return type

[**ProductPdfColorProfile**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductpdfcolorprofilesfkput"></a>
# **CustomersIdTeamsNkProductPdfColorProfilesFkPut**
> ProductPdfColorProfile CustomersIdTeamsNkProductPdfColorProfilesFkPut (string id, string nk, string fk, ProductPdfColorProfile data = null)

Update a related item by id for productPdfColorProfiles.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductPdfColorProfilesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productPdfColorProfiles
            var data = new ProductPdfColorProfile(); // ProductPdfColorProfile |  (optional) 

            try
            {
                // Update a related item by id for productPdfColorProfiles.
                ProductPdfColorProfile result = apiInstance.CustomersIdTeamsNkProductPdfColorProfilesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductPdfColorProfilesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productPdfColorProfiles | 
 **data** | [**ProductPdfColorProfile**](ProductPdfColorProfile.md)|  | [optional] 

### Return type

[**ProductPdfColorProfile**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductpdfcolorprofilesget"></a>
# **CustomersIdTeamsNkProductPdfColorProfilesGet**
> List<ProductPdfColorProfile> CustomersIdTeamsNkProductPdfColorProfilesGet (string id, string nk, string filter = null)

Queries productPdfColorProfiles of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductPdfColorProfilesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productPdfColorProfiles of Team.
                List&lt;ProductPdfColorProfile&gt; result = apiInstance.CustomersIdTeamsNkProductPdfColorProfilesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductPdfColorProfilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductPdfColorProfile>**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductsizematerialscountget"></a>
# **CustomersIdTeamsNkProductSizeMaterialsCountGet**
> InlineResponse200 CustomersIdTeamsNkProductSizeMaterialsCountGet (string id, string nk, string where = null)

Counts productSizeMaterials of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductSizeMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productSizeMaterials of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkProductSizeMaterialsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductSizeMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductsizematerialsdelete"></a>
# **CustomersIdTeamsNkProductSizeMaterialsDelete**
> void CustomersIdTeamsNkProductSizeMaterialsDelete (string id, string nk)

Deletes all productSizeMaterials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductSizeMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all productSizeMaterials of this model.
                apiInstance.CustomersIdTeamsNkProductSizeMaterialsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductSizeMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductsizematerialsfkdelete"></a>
# **CustomersIdTeamsNkProductSizeMaterialsFkDelete**
> void CustomersIdTeamsNkProductSizeMaterialsFkDelete (string id, string nk, string fk)

Delete a related item by id for productSizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductSizeMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productSizeMaterials

            try
            {
                // Delete a related item by id for productSizeMaterials.
                apiInstance.CustomersIdTeamsNkProductSizeMaterialsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductSizeMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productSizeMaterials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductsizematerialsfkget"></a>
# **CustomersIdTeamsNkProductSizeMaterialsFkGet**
> ProductSizeMaterial CustomersIdTeamsNkProductSizeMaterialsFkGet (string id, string nk, string fk)

Find a related item by id for productSizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductSizeMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productSizeMaterials

            try
            {
                // Find a related item by id for productSizeMaterials.
                ProductSizeMaterial result = apiInstance.CustomersIdTeamsNkProductSizeMaterialsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductSizeMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productSizeMaterials | 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductsizematerialsfkput"></a>
# **CustomersIdTeamsNkProductSizeMaterialsFkPut**
> ProductSizeMaterial CustomersIdTeamsNkProductSizeMaterialsFkPut (string id, string nk, string fk, ProductSizeMaterial data = null)

Update a related item by id for productSizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductSizeMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for productSizeMaterials
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Update a related item by id for productSizeMaterials.
                ProductSizeMaterial result = apiInstance.CustomersIdTeamsNkProductSizeMaterialsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductSizeMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for productSizeMaterials | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductsizematerialsget"></a>
# **CustomersIdTeamsNkProductSizeMaterialsGet**
> List<ProductSizeMaterial> CustomersIdTeamsNkProductSizeMaterialsGet (string id, string nk, string filter = null)

Queries productSizeMaterials of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductSizeMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productSizeMaterials of Team.
                List&lt;ProductSizeMaterial&gt; result = apiInstance.CustomersIdTeamsNkProductSizeMaterialsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductSizeMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductSizeMaterial>**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkproductsizematerialspost"></a>
# **CustomersIdTeamsNkProductSizeMaterialsPost**
> ProductSizeMaterial CustomersIdTeamsNkProductSizeMaterialsPost (string id, string nk, ProductSizeMaterial data = null)

Creates a new instance in productSizeMaterials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkProductSizeMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Creates a new instance in productSizeMaterials of this model.
                ProductSizeMaterial result = apiInstance.CustomersIdTeamsNkProductSizeMaterialsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkProductSizeMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkteamdataget"></a>
# **CustomersIdTeamsNkTeamDataGet**
> DynamicData CustomersIdTeamsNkTeamDataGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation teamData.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTeamDataGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation teamData.
                DynamicData result = apiInstance.CustomersIdTeamsNkTeamDataGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTeamDataGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkteammemberscountget"></a>
# **CustomersIdTeamsNkTeamMembersCountGet**
> InlineResponse200 CustomersIdTeamsNkTeamMembersCountGet (string id, string nk, string where = null)

Counts teamMembers of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTeamMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts teamMembers of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkTeamMembersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTeamMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkteammembersdelete"></a>
# **CustomersIdTeamsNkTeamMembersDelete**
> void CustomersIdTeamsNkTeamMembersDelete (string id, string nk)

Deletes all teamMembers of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTeamMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all teamMembers of this model.
                apiInstance.CustomersIdTeamsNkTeamMembersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTeamMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkteammembersfkdelete"></a>
# **CustomersIdTeamsNkTeamMembersFkDelete**
> void CustomersIdTeamsNkTeamMembersFkDelete (string id, string nk, string fk)

Delete a related item by id for teamMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTeamMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for teamMembers

            try
            {
                // Delete a related item by id for teamMembers.
                apiInstance.CustomersIdTeamsNkTeamMembersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTeamMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for teamMembers | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkteammembersfkget"></a>
# **CustomersIdTeamsNkTeamMembersFkGet**
> TeamMember CustomersIdTeamsNkTeamMembersFkGet (string id, string nk, string fk)

Find a related item by id for teamMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTeamMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for teamMembers

            try
            {
                // Find a related item by id for teamMembers.
                TeamMember result = apiInstance.CustomersIdTeamsNkTeamMembersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTeamMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for teamMembers | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkteammembersfkput"></a>
# **CustomersIdTeamsNkTeamMembersFkPut**
> TeamMember CustomersIdTeamsNkTeamMembersFkPut (string id, string nk, string fk, TeamMember data = null)

Update a related item by id for teamMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTeamMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for teamMembers
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for teamMembers.
                TeamMember result = apiInstance.CustomersIdTeamsNkTeamMembersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTeamMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for teamMembers | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkteammembersget"></a>
# **CustomersIdTeamsNkTeamMembersGet**
> List<TeamMember> CustomersIdTeamsNkTeamMembersGet (string id, string nk, string filter = null)

Queries teamMembers of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTeamMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries teamMembers of Team.
                List&lt;TeamMember&gt; result = apiInstance.CustomersIdTeamsNkTeamMembersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTeamMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkteammemberspost"></a>
# **CustomersIdTeamsNkTeamMembersPost**
> TeamMember CustomersIdTeamsNkTeamMembersPost (string id, string nk, TeamMember data = null)

Creates a new instance in teamMembers of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTeamMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in teamMembers of this model.
                TeamMember result = apiInstance.CustomersIdTeamsNkTeamMembersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTeamMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatefolderscountget"></a>
# **CustomersIdTeamsNkTemplateFoldersCountGet**
> InlineResponse200 CustomersIdTeamsNkTemplateFoldersCountGet (string id, string nk, string where = null)

Counts templateFolders of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplateFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templateFolders of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkTemplateFoldersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplateFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatefoldersdelete"></a>
# **CustomersIdTeamsNkTemplateFoldersDelete**
> void CustomersIdTeamsNkTemplateFoldersDelete (string id, string nk)

Deletes all templateFolders of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplateFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all templateFolders of this model.
                apiInstance.CustomersIdTeamsNkTemplateFoldersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplateFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatefoldersfkdelete"></a>
# **CustomersIdTeamsNkTemplateFoldersFkDelete**
> void CustomersIdTeamsNkTemplateFoldersFkDelete (string id, string nk, string fk)

Delete a related item by id for templateFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplateFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Delete a related item by id for templateFolders.
                apiInstance.CustomersIdTeamsNkTemplateFoldersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplateFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatefoldersfkget"></a>
# **CustomersIdTeamsNkTemplateFoldersFkGet**
> TeamTemplateFolder CustomersIdTeamsNkTemplateFoldersFkGet (string id, string nk, string fk)

Find a related item by id for templateFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplateFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Find a related item by id for templateFolders.
                TeamTemplateFolder result = apiInstance.CustomersIdTeamsNkTemplateFoldersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplateFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatefoldersfkput"></a>
# **CustomersIdTeamsNkTemplateFoldersFkPut**
> TeamTemplateFolder CustomersIdTeamsNkTemplateFoldersFkPut (string id, string nk, string fk, TeamTemplateFolder data = null)

Update a related item by id for templateFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplateFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for templateFolders
            var data = new TeamTemplateFolder(); // TeamTemplateFolder |  (optional) 

            try
            {
                // Update a related item by id for templateFolders.
                TeamTemplateFolder result = apiInstance.CustomersIdTeamsNkTemplateFoldersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplateFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for templateFolders | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)|  | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatefoldersget"></a>
# **CustomersIdTeamsNkTemplateFoldersGet**
> List<TeamTemplateFolder> CustomersIdTeamsNkTemplateFoldersGet (string id, string nk, string filter = null)

Queries templateFolders of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplateFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templateFolders of Team.
                List&lt;TeamTemplateFolder&gt; result = apiInstance.CustomersIdTeamsNkTemplateFoldersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplateFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamTemplateFolder>**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatefolderspost"></a>
# **CustomersIdTeamsNkTemplateFoldersPost**
> TeamTemplateFolder CustomersIdTeamsNkTemplateFoldersPost (string id, string nk, TeamTemplateFolder data = null)

Creates a new instance in templateFolders of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplateFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new TeamTemplateFolder(); // TeamTemplateFolder |  (optional) 

            try
            {
                // Creates a new instance in templateFolders of this model.
                TeamTemplateFolder result = apiInstance.CustomersIdTeamsNkTemplateFoldersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplateFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)|  | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatescountget"></a>
# **CustomersIdTeamsNkTemplatesCountGet**
> InlineResponse200 CustomersIdTeamsNkTemplatesCountGet (string id, string nk, string where = null)

Counts templates of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkTemplatesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatesdelete"></a>
# **CustomersIdTeamsNkTemplatesDelete**
> void CustomersIdTeamsNkTemplatesDelete (string id, string nk)

Deletes all templates of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all templates of this model.
                apiInstance.CustomersIdTeamsNkTemplatesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatesfkdelete"></a>
# **CustomersIdTeamsNkTemplatesFkDelete**
> void CustomersIdTeamsNkTemplatesFkDelete (string id, string nk, string fk)

Delete a related item by id for templates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.CustomersIdTeamsNkTemplatesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatesfkget"></a>
# **CustomersIdTeamsNkTemplatesFkGet**
> Template CustomersIdTeamsNkTemplatesFkGet (string id, string nk, string fk)

Find a related item by id for templates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.CustomersIdTeamsNkTemplatesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatesfkput"></a>
# **CustomersIdTeamsNkTemplatesFkPut**
> Template CustomersIdTeamsNkTemplatesFkPut (string id, string nk, string fk, Template data = null)

Update a related item by id for templates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.CustomersIdTeamsNkTemplatesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for templates | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatesget"></a>
# **CustomersIdTeamsNkTemplatesGet**
> List<Template> CustomersIdTeamsNkTemplatesGet (string id, string nk, string filter = null)

Queries templates of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of Team.
                List&lt;Template&gt; result = apiInstance.CustomersIdTeamsNkTemplatesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnktemplatespost"></a>
# **CustomersIdTeamsNkTemplatesPost**
> Template CustomersIdTeamsNkTemplatesPost (string id, string nk, Template data = null)

Creates a new instance in templates of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.CustomersIdTeamsNkTemplatesPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkworkflowscountget"></a>
# **CustomersIdTeamsNkWorkflowsCountGet**
> InlineResponse200 CustomersIdTeamsNkWorkflowsCountGet (string id, string nk, string where = null)

Counts workflows of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkWorkflowsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts workflows of Team.
                InlineResponse200 result = apiInstance.CustomersIdTeamsNkWorkflowsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkWorkflowsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkworkflowsdelete"></a>
# **CustomersIdTeamsNkWorkflowsDelete**
> void CustomersIdTeamsNkWorkflowsDelete (string id, string nk)

Deletes all workflows of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkWorkflowsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.

            try
            {
                // Deletes all workflows of this model.
                apiInstance.CustomersIdTeamsNkWorkflowsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkWorkflowsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkworkflowsfkdelete"></a>
# **CustomersIdTeamsNkWorkflowsFkDelete**
> void CustomersIdTeamsNkWorkflowsFkDelete (string id, string nk, string fk)

Delete a related item by id for workflows.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkWorkflowsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for workflows

            try
            {
                // Delete a related item by id for workflows.
                apiInstance.CustomersIdTeamsNkWorkflowsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkWorkflowsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for workflows | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkworkflowsfkget"></a>
# **CustomersIdTeamsNkWorkflowsFkGet**
> Workflow CustomersIdTeamsNkWorkflowsFkGet (string id, string nk, string fk)

Find a related item by id for workflows.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkWorkflowsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for workflows

            try
            {
                // Find a related item by id for workflows.
                Workflow result = apiInstance.CustomersIdTeamsNkWorkflowsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkWorkflowsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for workflows | 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkworkflowsfkput"></a>
# **CustomersIdTeamsNkWorkflowsFkPut**
> Workflow CustomersIdTeamsNkWorkflowsFkPut (string id, string nk, string fk, Workflow data = null)

Update a related item by id for workflows.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkWorkflowsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var fk = fk_example;  // string | Foreign key for workflows
            var data = new Workflow(); // Workflow |  (optional) 

            try
            {
                // Update a related item by id for workflows.
                Workflow result = apiInstance.CustomersIdTeamsNkWorkflowsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkWorkflowsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **fk** | **string**| Foreign key for workflows | 
 **data** | [**Workflow**](Workflow.md)|  | [optional] 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkworkflowsget"></a>
# **CustomersIdTeamsNkWorkflowsGet**
> List<Workflow> CustomersIdTeamsNkWorkflowsGet (string id, string nk, string filter = null)

Queries workflows of Team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkWorkflowsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries workflows of Team.
                List&lt;Workflow&gt; result = apiInstance.CustomersIdTeamsNkWorkflowsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkWorkflowsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Workflow>**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsnkworkflowspost"></a>
# **CustomersIdTeamsNkWorkflowsPost**
> Workflow CustomersIdTeamsNkWorkflowsPost (string id, string nk, Workflow data = null)

Creates a new instance in workflows of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsNkWorkflowsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var nk = nk_example;  // string | Foreign key for teams.
            var data = new Workflow(); // Workflow |  (optional) 

            try
            {
                // Creates a new instance in workflows of this model.
                Workflow result = apiInstance.CustomersIdTeamsNkWorkflowsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsNkWorkflowsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **nk** | **string**| Foreign key for teams. | 
 **data** | [**Workflow**](Workflow.md)|  | [optional] 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamspost"></a>
# **CustomersIdTeamsPost**
> Team CustomersIdTeamsPost (string id, Team data = null)

Creates a new instance in teams of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var data = new Team(); // Team |  (optional) 

            try
            {
                // Creates a new instance in teams of this model.
                Team result = apiInstance.CustomersIdTeamsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **data** | [**Team**](Team.md)|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsrelfkdelete"></a>
# **CustomersIdTeamsRelFkDelete**
> void CustomersIdTeamsRelFkDelete (string id, string fk)

Remove the teams relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for teams

            try
            {
                // Remove the teams relation to an item by id.
                apiInstance.CustomersIdTeamsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for teams | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsrelfkhead"></a>
# **CustomersIdTeamsRelFkHead**
> bool? CustomersIdTeamsRelFkHead (string id, string fk)

Check the existence of teams relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for teams

            try
            {
                // Check the existence of teams relation to an item by id.
                bool? result = apiInstance.CustomersIdTeamsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for teams | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsrelfkput"></a>
# **CustomersIdTeamsRelFkPut**
> TeamMember CustomersIdTeamsRelFkPut (string id, string fk, TeamMember data = null)

Add a related item by id for teams.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var fk = fk_example;  // string | Foreign key for teams
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Add a related item by id for teams.
                TeamMember result = apiInstance.CustomersIdTeamsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **fk** | **string**| Foreign key for teams | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsteamidchangepost"></a>
# **CustomersIdTeamsTeamIdChangePost**
> TeamMemberAccessToken CustomersIdTeamsTeamIdChangePost (string id, string id2, string teamId)

Move authentication to a Team

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsTeamIdChangePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var id2 = id_example;  // string | Customer id
            var teamId = teamId_example;  // string | Team id

            try
            {
                // Move authentication to a Team
                TeamMemberAccessToken result = apiInstance.CustomersIdTeamsTeamIdChangePost(id, id2, teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsTeamIdChangePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **id2** | **string**| Customer id | 
 **teamId** | **string**| Team id | 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidteamsteamidportalsportalidchangepost"></a>
# **CustomersIdTeamsTeamIdPortalsPortalIdChangePost**
> TeamMemberAccessToken CustomersIdTeamsTeamIdPortalsPortalIdChangePost (string id, string id2, string teamId, string portalId)

Move authentication to a Portal

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTeamsTeamIdPortalsPortalIdChangePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var id2 = id_example;  // string | Customer id
            var teamId = teamId_example;  // string | Team id
            var portalId = portalId_example;  // string | Portal id

            try
            {
                // Move authentication to a Portal
                TeamMemberAccessToken result = apiInstance.CustomersIdTeamsTeamIdPortalsPortalIdChangePost(id, id2, teamId, portalId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTeamsTeamIdPortalsPortalIdChangePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **id2** | **string**| Customer id | 
 **teamId** | **string**| Team id | 
 **portalId** | **string**| Portal id | 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidtokenget"></a>
# **CustomersIdTokenGet**
> TeamMemberAccessToken CustomersIdTokenGet (string id, string id2)

Get token info

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdTokenGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id
            var id2 = id_example;  // string | Customer id

            try
            {
                // Get token info
                TeamMemberAccessToken result = apiInstance.CustomersIdTokenGet(id, id2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdTokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 
 **id2** | **string**| Customer id | 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersidverifypost"></a>
# **CustomersIdVerifyPost**
> void CustomersIdVerifyPost (string id)

Trigger user's identity verification with configured verifyOptions

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersIdVerifyPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | Customer id

            try
            {
                // Trigger user's identity verification with configured verifyOptions
                apiInstance.CustomersIdVerifyPost(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersIdVerifyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Customer id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersinvitationticketstokenacceptpost"></a>
# **CustomersInvitationTicketsTokenAcceptPost**
> InvitationTicket CustomersInvitationTicketsTokenAcceptPost (string token, Customer data = null)

Accept invitation with token

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersInvitationTicketsTokenAcceptPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var token = token_example;  // string | Token describing invitation ticket
            var data = new Customer(); // Customer | Customer data in case new customer (optional) 

            try
            {
                // Accept invitation with token
                InvitationTicket result = apiInstance.CustomersInvitationTicketsTokenAcceptPost(token, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersInvitationTicketsTokenAcceptPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| Token describing invitation ticket | 
 **data** | [**Customer**](Customer.md)| Customer data in case new customer | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersinvitationticketstokenget"></a>
# **CustomersInvitationTicketsTokenGet**
> InvitationTicket CustomersInvitationTicketsTokenGet (string token)

Get invitation details with token

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersInvitationTicketsTokenGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var token = token_example;  // string | Token describing invitation ticket

            try
            {
                // Get invitation details with token
                InvitationTicket result = apiInstance.CustomersInvitationTicketsTokenGet(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersInvitationTicketsTokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| Token describing invitation ticket | 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersloginpost"></a>
# **CustomersLoginPost**
> Object CustomersLoginPost (Object credentials, string include = null)

Login a user with username/email and password.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersLoginPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var credentials = ;  // Object | 
            var include = include_example;  // string | Related objects to include in the response. See the description of return value for more details. (optional) 

            try
            {
                // Login a user with username/email and password.
                Object result = apiInstance.CustomersLoginPost(credentials, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersLoginPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credentials** | **Object**|  | 
 **include** | **string**| Related objects to include in the response. See the description of return value for more details. | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerslogoutpost"></a>
# **CustomersLogoutPost**
> void CustomersLogoutPost ()

Logout a user with access token.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersLogoutPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();

            try
            {
                // Logout a user with access token.
                apiInstance.CustomersLogoutPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersLogoutPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersmetokenget"></a>
# **CustomersMeTokenGet**
> TeamMemberAccessToken CustomersMeTokenGet ()

Get token info

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersMeTokenGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();

            try
            {
                // Get token info
                TeamMemberAccessToken result = apiInstance.CustomersMeTokenGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersMeTokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersmetokenrefreshget"></a>
# **CustomersMeTokenRefreshGet**
> TeamMemberAccessToken CustomersMeTokenRefreshGet (string refreshToken)

Refresh current access token

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersMeTokenRefreshGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var refreshToken = refreshToken_example;  // string | AccessToken refreshToken

            try
            {
                // Refresh current access token
                TeamMemberAccessToken result = apiInstance.CustomersMeTokenRefreshGet(refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersMeTokenRefreshGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refreshToken** | **string**| AccessToken refreshToken | 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerspatch"></a>
# **CustomersPatch**
> Customer CustomersPatch (Customer data = null)

Patch an existing model instance or insert a new one into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var data = new Customer(); // Customer | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                Customer result = apiInstance.CustomersPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Customer**](Customer.md)| Model instance data | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerspost"></a>
# **CustomersPost**
> Customer CustomersPost (Customer data = null)

Create a new instance of the model and persist it into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var data = new Customer(); // Customer | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                Customer result = apiInstance.CustomersPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Customer**](Customer.md)| Model instance data | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersput"></a>
# **CustomersPut**
> Customer CustomersPut (Customer data = null)

Replace an existing model instance or insert a new one into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var data = new Customer(); // Customer | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Customer result = apiInstance.CustomersPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Customer**](Customer.md)| Model instance data | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersregisterpost"></a>
# **CustomersRegisterPost**
> TeamMember CustomersRegisterPost (Customer data = null)

Create customer and assign it to a team

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersRegisterPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var data = new Customer(); // Customer | Model instance data (optional) 

            try
            {
                // Create customer and assign it to a team
                TeamMember result = apiInstance.CustomersRegisterPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersRegisterPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Customer**](Customer.md)| Model instance data | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersreplaceorcreatepost"></a>
# **CustomersReplaceOrCreatePost**
> Customer CustomersReplaceOrCreatePost (Customer data = null)

Replace an existing model instance or insert a new one into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var data = new Customer(); // Customer | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Customer result = apiInstance.CustomersReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Customer**](Customer.md)| Model instance data | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersresetpasswordpost"></a>
# **CustomersResetPasswordPost**
> void CustomersResetPasswordPost (string newPassword)

Reset user's password via a password-reset token.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersResetPasswordPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var newPassword = newPassword_example;  // string | 

            try
            {
                // Reset user's password via a password-reset token.
                apiInstance.CustomersResetPasswordPost(newPassword);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersResetPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newPassword** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersresetpasswordtokenget"></a>
# **CustomersResetPasswordTokenGet**
> TeamMemberAccessToken CustomersResetPasswordTokenGet (string token)

Get token info for reset password token

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersResetPasswordTokenGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var token = token_example;  // string | Reset password access token

            try
            {
                // Get token info for reset password token
                TeamMemberAccessToken result = apiInstance.CustomersResetPasswordTokenGet(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersResetPasswordTokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| Reset password access token | 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersresetpost"></a>
# **CustomersResetPost**
> void CustomersResetPost (Object options)

Reset password for a user with email.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersResetPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var options = ;  // Object | 

            try
            {
                // Reset password for a user with email.
                apiInstance.CustomersResetPost(options);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersResetPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **options** | **Object**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersupdatepost"></a>
# **CustomersUpdatePost**
> InlineResponse2002 CustomersUpdatePost (string where = null, Customer data = null)

Update instances of the model matched by {{where}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Customer(); // Customer | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.CustomersUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Customer**](Customer.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersupsertwithwherepost"></a>
# **CustomersUpsertWithWherePost**
> Customer CustomersUpsertWithWherePost (string where = null, Customer data = null)

Update an existing model instance or insert a new one into the data source based on the where criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class CustomersUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new CustomerApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Customer(); // Customer | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                Customer result = apiInstance.CustomersUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomersUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Customer**](Customer.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

