# TweakApi.Api.TeamApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamsChangeStreamGet**](TeamApi.md#teamschangestreamget) | **GET** /Teams/change-stream | Create a change stream.
[**TeamsChangeStreamPost**](TeamApi.md#teamschangestreampost) | **POST** /Teams/change-stream | Create a change stream.
[**TeamsCountGet**](TeamApi.md#teamscountget) | **GET** /Teams/count | Count instances of the model matched by where from the data source.
[**TeamsFindOneGet**](TeamApi.md#teamsfindoneget) | **GET** /Teams/findOne | Find first instance of the model matched by filter from the data source.
[**TeamsGet**](TeamApi.md#teamsget) | **GET** /Teams | Find all instances of the model matched by filter from the data source.
[**TeamsIdBillingDelete**](TeamApi.md#teamsidbillingdelete) | **DELETE** /Teams/{id}/billing | Deletes billing of this model.
[**TeamsIdBillingGet**](TeamApi.md#teamsidbillingget) | **GET** /Teams/{id}/billing | Fetches hasOne relation billing.
[**TeamsIdBillingPost**](TeamApi.md#teamsidbillingpost) | **POST** /Teams/{id}/billing | Creates a new instance in billing of this model.
[**TeamsIdBillingPut**](TeamApi.md#teamsidbillingput) | **PUT** /Teams/{id}/billing | Update billing of this model.
[**TeamsIdBrandDelete**](TeamApi.md#teamsidbranddelete) | **DELETE** /Teams/{id}/brand | Deletes brand of this model.
[**TeamsIdBrandGet**](TeamApi.md#teamsidbrandget) | **GET** /Teams/{id}/brand | Fetches hasOne relation brand.
[**TeamsIdBrandPost**](TeamApi.md#teamsidbrandpost) | **POST** /Teams/{id}/brand | Creates a new instance in brand of this model.
[**TeamsIdBrandPut**](TeamApi.md#teamsidbrandput) | **PUT** /Teams/{id}/brand | Update brand of this model.
[**TeamsIdDataSourcesCountGet**](TeamApi.md#teamsiddatasourcescountget) | **GET** /Teams/{id}/dataSources/count | Counts dataSources of Team.
[**TeamsIdDataSourcesDelete**](TeamApi.md#teamsiddatasourcesdelete) | **DELETE** /Teams/{id}/dataSources | Deletes all dataSources of this model.
[**TeamsIdDataSourcesFkDelete**](TeamApi.md#teamsiddatasourcesfkdelete) | **DELETE** /Teams/{id}/dataSources/{fk} | Delete a related item by id for dataSources.
[**TeamsIdDataSourcesFkGet**](TeamApi.md#teamsiddatasourcesfkget) | **GET** /Teams/{id}/dataSources/{fk} | Find a related item by id for dataSources.
[**TeamsIdDataSourcesFkPut**](TeamApi.md#teamsiddatasourcesfkput) | **PUT** /Teams/{id}/dataSources/{fk} | Update a related item by id for dataSources.
[**TeamsIdDataSourcesGet**](TeamApi.md#teamsiddatasourcesget) | **GET** /Teams/{id}/dataSources | Queries dataSources of Team.
[**TeamsIdDataSourcesPost**](TeamApi.md#teamsiddatasourcespost) | **POST** /Teams/{id}/dataSources | Creates a new instance in dataSources of this model.
[**TeamsIdDelete**](TeamApi.md#teamsiddelete) | **DELETE** /Teams/{id} | Delete a model instance by {{id}} from the data source.
[**TeamsIdExistsGet**](TeamApi.md#teamsidexistsget) | **GET** /Teams/{id}/exists | Check whether a model instance exists in the data source.
[**TeamsIdGet**](TeamApi.md#teamsidget) | **GET** /Teams/{id} | Find a model instance by {{id}} from the data source.
[**TeamsIdHead**](TeamApi.md#teamsidhead) | **HEAD** /Teams/{id} | Check whether a model instance exists in the data source.
[**TeamsIdImageFoldersCountGet**](TeamApi.md#teamsidimagefolderscountget) | **GET** /Teams/{id}/imageFolders/count | Counts imageFolders of Team.
[**TeamsIdImageFoldersDelete**](TeamApi.md#teamsidimagefoldersdelete) | **DELETE** /Teams/{id}/imageFolders | Deletes all imageFolders of this model.
[**TeamsIdImageFoldersFkDelete**](TeamApi.md#teamsidimagefoldersfkdelete) | **DELETE** /Teams/{id}/imageFolders/{fk} | Delete a related item by id for imageFolders.
[**TeamsIdImageFoldersFkGet**](TeamApi.md#teamsidimagefoldersfkget) | **GET** /Teams/{id}/imageFolders/{fk} | Find a related item by id for imageFolders.
[**TeamsIdImageFoldersFkPut**](TeamApi.md#teamsidimagefoldersfkput) | **PUT** /Teams/{id}/imageFolders/{fk} | Update a related item by id for imageFolders.
[**TeamsIdImageFoldersGet**](TeamApi.md#teamsidimagefoldersget) | **GET** /Teams/{id}/imageFolders | Queries imageFolders of Team.
[**TeamsIdImageFoldersNkChildrenCountGet**](TeamApi.md#teamsidimagefoldersnkchildrencountget) | **GET** /Teams/{id}/imageFolders/{nk}/children/count | Counts children of ImageFolder.
[**TeamsIdImageFoldersNkChildrenDelete**](TeamApi.md#teamsidimagefoldersnkchildrendelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/children | Deletes all children of this model.
[**TeamsIdImageFoldersNkChildrenFkDelete**](TeamApi.md#teamsidimagefoldersnkchildrenfkdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/children/{fk} | Delete a related item by id for children.
[**TeamsIdImageFoldersNkChildrenFkGet**](TeamApi.md#teamsidimagefoldersnkchildrenfkget) | **GET** /Teams/{id}/imageFolders/{nk}/children/{fk} | Find a related item by id for children.
[**TeamsIdImageFoldersNkChildrenFkPut**](TeamApi.md#teamsidimagefoldersnkchildrenfkput) | **PUT** /Teams/{id}/imageFolders/{nk}/children/{fk} | Update a related item by id for children.
[**TeamsIdImageFoldersNkChildrenGet**](TeamApi.md#teamsidimagefoldersnkchildrenget) | **GET** /Teams/{id}/imageFolders/{nk}/children | Queries children of ImageFolder.
[**TeamsIdImageFoldersNkChildrenPost**](TeamApi.md#teamsidimagefoldersnkchildrenpost) | **POST** /Teams/{id}/imageFolders/{nk}/children | Creates a new instance in children of this model.
[**TeamsIdImageFoldersNkFolderMembersCountGet**](TeamApi.md#teamsidimagefoldersnkfoldermemberscountget) | **GET** /Teams/{id}/imageFolders/{nk}/folderMembers/count | Counts folderMembers of ImageFolder.
[**TeamsIdImageFoldersNkFolderMembersDelete**](TeamApi.md#teamsidimagefoldersnkfoldermembersdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/folderMembers | Deletes all folderMembers of this model.
[**TeamsIdImageFoldersNkFolderMembersFkDelete**](TeamApi.md#teamsidimagefoldersnkfoldermembersfkdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/folderMembers/{fk} | Delete a related item by id for folderMembers.
[**TeamsIdImageFoldersNkFolderMembersFkGet**](TeamApi.md#teamsidimagefoldersnkfoldermembersfkget) | **GET** /Teams/{id}/imageFolders/{nk}/folderMembers/{fk} | Find a related item by id for folderMembers.
[**TeamsIdImageFoldersNkFolderMembersFkPut**](TeamApi.md#teamsidimagefoldersnkfoldermembersfkput) | **PUT** /Teams/{id}/imageFolders/{nk}/folderMembers/{fk} | Update a related item by id for folderMembers.
[**TeamsIdImageFoldersNkFolderMembersGet**](TeamApi.md#teamsidimagefoldersnkfoldermembersget) | **GET** /Teams/{id}/imageFolders/{nk}/folderMembers | Queries folderMembers of ImageFolder.
[**TeamsIdImageFoldersNkFolderMembersPost**](TeamApi.md#teamsidimagefoldersnkfoldermemberspost) | **POST** /Teams/{id}/imageFolders/{nk}/folderMembers | Creates a new instance in folderMembers of this model.
[**TeamsIdImageFoldersNkImagesCountGet**](TeamApi.md#teamsidimagefoldersnkimagescountget) | **GET** /Teams/{id}/imageFolders/{nk}/images/count | Counts images of ImageFolder.
[**TeamsIdImageFoldersNkImagesDelete**](TeamApi.md#teamsidimagefoldersnkimagesdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/images | Deletes all images of this model.
[**TeamsIdImageFoldersNkImagesFkDelete**](TeamApi.md#teamsidimagefoldersnkimagesfkdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/images/{fk} | Delete a related item by id for images.
[**TeamsIdImageFoldersNkImagesFkGet**](TeamApi.md#teamsidimagefoldersnkimagesfkget) | **GET** /Teams/{id}/imageFolders/{nk}/images/{fk} | Find a related item by id for images.
[**TeamsIdImageFoldersNkImagesFkPut**](TeamApi.md#teamsidimagefoldersnkimagesfkput) | **PUT** /Teams/{id}/imageFolders/{nk}/images/{fk} | Update a related item by id for images.
[**TeamsIdImageFoldersNkImagesGet**](TeamApi.md#teamsidimagefoldersnkimagesget) | **GET** /Teams/{id}/imageFolders/{nk}/images | Queries images of ImageFolder.
[**TeamsIdImageFoldersNkImagesPost**](TeamApi.md#teamsidimagefoldersnkimagespost) | **POST** /Teams/{id}/imageFolders/{nk}/images | Creates a new instance in images of this model.
[**TeamsIdImageFoldersNkMembersCountGet**](TeamApi.md#teamsidimagefoldersnkmemberscountget) | **GET** /Teams/{id}/imageFolders/{nk}/members/count | Counts members of ImageFolder.
[**TeamsIdImageFoldersNkMembersDelete**](TeamApi.md#teamsidimagefoldersnkmembersdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/members | Deletes all members of this model.
[**TeamsIdImageFoldersNkMembersFkDelete**](TeamApi.md#teamsidimagefoldersnkmembersfkdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/members/{fk} | Delete a related item by id for members.
[**TeamsIdImageFoldersNkMembersFkGet**](TeamApi.md#teamsidimagefoldersnkmembersfkget) | **GET** /Teams/{id}/imageFolders/{nk}/members/{fk} | Find a related item by id for members.
[**TeamsIdImageFoldersNkMembersFkPut**](TeamApi.md#teamsidimagefoldersnkmembersfkput) | **PUT** /Teams/{id}/imageFolders/{nk}/members/{fk} | Update a related item by id for members.
[**TeamsIdImageFoldersNkMembersGet**](TeamApi.md#teamsidimagefoldersnkmembersget) | **GET** /Teams/{id}/imageFolders/{nk}/members | Queries members of ImageFolder.
[**TeamsIdImageFoldersNkMembersPost**](TeamApi.md#teamsidimagefoldersnkmemberspost) | **POST** /Teams/{id}/imageFolders/{nk}/members | Creates a new instance in members of this model.
[**TeamsIdImageFoldersNkMembersRelFkDelete**](TeamApi.md#teamsidimagefoldersnkmembersrelfkdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/members/rel/{fk} | Remove the members relation to an item by id.
[**TeamsIdImageFoldersNkMembersRelFkHead**](TeamApi.md#teamsidimagefoldersnkmembersrelfkhead) | **HEAD** /Teams/{id}/imageFolders/{nk}/members/rel/{fk} | Check the existence of members relation to an item by id.
[**TeamsIdImageFoldersNkMembersRelFkPut**](TeamApi.md#teamsidimagefoldersnkmembersrelfkput) | **PUT** /Teams/{id}/imageFolders/{nk}/members/rel/{fk} | Add a related item by id for members.
[**TeamsIdImageFoldersNkParentGet**](TeamApi.md#teamsidimagefoldersnkparentget) | **GET** /Teams/{id}/imageFolders/{nk}/parent | Fetches belongsTo relation parent.
[**TeamsIdImageFoldersNkPortalsCountGet**](TeamApi.md#teamsidimagefoldersnkportalscountget) | **GET** /Teams/{id}/imageFolders/{nk}/portals/count | Counts portals of ImageFolder.
[**TeamsIdImageFoldersNkPortalsDelete**](TeamApi.md#teamsidimagefoldersnkportalsdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/portals | Deletes all portals of this model.
[**TeamsIdImageFoldersNkPortalsFkDelete**](TeamApi.md#teamsidimagefoldersnkportalsfkdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/portals/{fk} | Delete a related item by id for portals.
[**TeamsIdImageFoldersNkPortalsFkGet**](TeamApi.md#teamsidimagefoldersnkportalsfkget) | **GET** /Teams/{id}/imageFolders/{nk}/portals/{fk} | Find a related item by id for portals.
[**TeamsIdImageFoldersNkPortalsFkPut**](TeamApi.md#teamsidimagefoldersnkportalsfkput) | **PUT** /Teams/{id}/imageFolders/{nk}/portals/{fk} | Update a related item by id for portals.
[**TeamsIdImageFoldersNkPortalsGet**](TeamApi.md#teamsidimagefoldersnkportalsget) | **GET** /Teams/{id}/imageFolders/{nk}/portals | Queries portals of ImageFolder.
[**TeamsIdImageFoldersNkPortalsPost**](TeamApi.md#teamsidimagefoldersnkportalspost) | **POST** /Teams/{id}/imageFolders/{nk}/portals | Creates a new instance in portals of this model.
[**TeamsIdImageFoldersNkPortalsRelFkDelete**](TeamApi.md#teamsidimagefoldersnkportalsrelfkdelete) | **DELETE** /Teams/{id}/imageFolders/{nk}/portals/rel/{fk} | Remove the portals relation to an item by id.
[**TeamsIdImageFoldersNkPortalsRelFkHead**](TeamApi.md#teamsidimagefoldersnkportalsrelfkhead) | **HEAD** /Teams/{id}/imageFolders/{nk}/portals/rel/{fk} | Check the existence of portals relation to an item by id.
[**TeamsIdImageFoldersNkPortalsRelFkPut**](TeamApi.md#teamsidimagefoldersnkportalsrelfkput) | **PUT** /Teams/{id}/imageFolders/{nk}/portals/rel/{fk} | Add a related item by id for portals.
[**TeamsIdImageFoldersNkTeamGet**](TeamApi.md#teamsidimagefoldersnkteamget) | **GET** /Teams/{id}/imageFolders/{nk}/team | Fetches belongsTo relation team.
[**TeamsIdImageFoldersPost**](TeamApi.md#teamsidimagefolderspost) | **POST** /Teams/{id}/imageFolders | Creates a new instance in imageFolders of this model.
[**TeamsIdImagesCountGet**](TeamApi.md#teamsidimagescountget) | **GET** /Teams/{id}/images/count | Counts images of Team.
[**TeamsIdImagesDelete**](TeamApi.md#teamsidimagesdelete) | **DELETE** /Teams/{id}/images | Deletes all images of this model.
[**TeamsIdImagesFkDelete**](TeamApi.md#teamsidimagesfkdelete) | **DELETE** /Teams/{id}/images/{fk} | Delete a related item by id for images.
[**TeamsIdImagesFkGet**](TeamApi.md#teamsidimagesfkget) | **GET** /Teams/{id}/images/{fk} | Find a related item by id for images.
[**TeamsIdImagesFkPut**](TeamApi.md#teamsidimagesfkput) | **PUT** /Teams/{id}/images/{fk} | Update a related item by id for images.
[**TeamsIdImagesGet**](TeamApi.md#teamsidimagesget) | **GET** /Teams/{id}/images | Queries images of Team.
[**TeamsIdImagesNkFolderGet**](TeamApi.md#teamsidimagesnkfolderget) | **GET** /Teams/{id}/images/{nk}/folder | Fetches belongsTo relation folder.
[**TeamsIdImagesNkTeamGet**](TeamApi.md#teamsidimagesnkteamget) | **GET** /Teams/{id}/images/{nk}/team | Fetches belongsTo relation team.
[**TeamsIdImagesPost**](TeamApi.md#teamsidimagespost) | **POST** /Teams/{id}/images | Creates a new instance in images of this model.
[**TeamsIdInvitationTicketsFkDelete**](TeamApi.md#teamsidinvitationticketsfkdelete) | **DELETE** /Teams/{id}/invitationTickets/{fk} | Delete InvitationTickets for this Team
[**TeamsIdInvitationTicketsFkGet**](TeamApi.md#teamsidinvitationticketsfkget) | **GET** /Teams/{id}/invitationTickets/{fk} | Get InvitationTicket by Id for this Team
[**TeamsIdInvitationTicketsGet**](TeamApi.md#teamsidinvitationticketsget) | **GET** /Teams/{id}/invitationTickets | List InvitationTickets for this Team
[**TeamsIdLogoPut**](TeamApi.md#teamsidlogoput) | **PUT** /Teams/{id}/logo | Change logo
[**TeamsIdMembersCountGet**](TeamApi.md#teamsidmemberscountget) | **GET** /Teams/{id}/members/count | Counts members of Team.
[**TeamsIdMembersDelete**](TeamApi.md#teamsidmembersdelete) | **DELETE** /Teams/{id}/members | Deletes all members of this model.
[**TeamsIdMembersFkDelete**](TeamApi.md#teamsidmembersfkdelete) | **DELETE** /Teams/{id}/members/{fk} | Delete a related item by id for members.
[**TeamsIdMembersFkGet**](TeamApi.md#teamsidmembersfkget) | **GET** /Teams/{id}/members/{fk} | Find a related item by id for members.
[**TeamsIdMembersFkPut**](TeamApi.md#teamsidmembersfkput) | **PUT** /Teams/{id}/members/{fk} | Update a related item by id for members.
[**TeamsIdMembersGet**](TeamApi.md#teamsidmembersget) | **GET** /Teams/{id}/members | Queries members of Team.
[**TeamsIdMembersPost**](TeamApi.md#teamsidmemberspost) | **POST** /Teams/{id}/members | Creates a new instance in members of this model.
[**TeamsIdMembersRelFkDelete**](TeamApi.md#teamsidmembersrelfkdelete) | **DELETE** /Teams/{id}/members/rel/{fk} | Remove the members relation to an item by id.
[**TeamsIdMembersRelFkHead**](TeamApi.md#teamsidmembersrelfkhead) | **HEAD** /Teams/{id}/members/rel/{fk} | Check the existence of members relation to an item by id.
[**TeamsIdMembersRelFkPut**](TeamApi.md#teamsidmembersrelfkput) | **PUT** /Teams/{id}/members/rel/{fk} | Add a related item by id for members.
[**TeamsIdPatch**](TeamApi.md#teamsidpatch) | **PATCH** /Teams/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamsIdPermissionDelete**](TeamApi.md#teamsidpermissiondelete) | **DELETE** /Teams/{id}/permission | Deletes permission of this model.
[**TeamsIdPermissionGet**](TeamApi.md#teamsidpermissionget) | **GET** /Teams/{id}/permission | Fetches hasOne relation permission.
[**TeamsIdPermissionPost**](TeamApi.md#teamsidpermissionpost) | **POST** /Teams/{id}/permission | Creates a new instance in permission of this model.
[**TeamsIdPermissionPut**](TeamApi.md#teamsidpermissionput) | **PUT** /Teams/{id}/permission | Update permission of this model.
[**TeamsIdPortalsCountGet**](TeamApi.md#teamsidportalscountget) | **GET** /Teams/{id}/portals/count | Counts portals of Team.
[**TeamsIdPortalsDelete**](TeamApi.md#teamsidportalsdelete) | **DELETE** /Teams/{id}/portals | Deletes all portals of this model.
[**TeamsIdPortalsFkDelete**](TeamApi.md#teamsidportalsfkdelete) | **DELETE** /Teams/{id}/portals/{fk} | Delete a related item by id for portals.
[**TeamsIdPortalsFkGet**](TeamApi.md#teamsidportalsfkget) | **GET** /Teams/{id}/portals/{fk} | Find a related item by id for portals.
[**TeamsIdPortalsFkPut**](TeamApi.md#teamsidportalsfkput) | **PUT** /Teams/{id}/portals/{fk} | Update a related item by id for portals.
[**TeamsIdPortalsGet**](TeamApi.md#teamsidportalsget) | **GET** /Teams/{id}/portals | Queries portals of Team.
[**TeamsIdPortalsNkDesignFoldersCountGet**](TeamApi.md#teamsidportalsnkdesignfolderscountget) | **GET** /Teams/{id}/portals/{nk}/designFolders/count | Counts designFolders of Portal.
[**TeamsIdPortalsNkDesignFoldersDelete**](TeamApi.md#teamsidportalsnkdesignfoldersdelete) | **DELETE** /Teams/{id}/portals/{nk}/designFolders | Deletes all designFolders of this model.
[**TeamsIdPortalsNkDesignFoldersFkDelete**](TeamApi.md#teamsidportalsnkdesignfoldersfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/designFolders/{fk} | Delete a related item by id for designFolders.
[**TeamsIdPortalsNkDesignFoldersFkGet**](TeamApi.md#teamsidportalsnkdesignfoldersfkget) | **GET** /Teams/{id}/portals/{nk}/designFolders/{fk} | Find a related item by id for designFolders.
[**TeamsIdPortalsNkDesignFoldersFkPut**](TeamApi.md#teamsidportalsnkdesignfoldersfkput) | **PUT** /Teams/{id}/portals/{nk}/designFolders/{fk} | Update a related item by id for designFolders.
[**TeamsIdPortalsNkDesignFoldersGet**](TeamApi.md#teamsidportalsnkdesignfoldersget) | **GET** /Teams/{id}/portals/{nk}/designFolders | Queries designFolders of Portal.
[**TeamsIdPortalsNkDesignFoldersPost**](TeamApi.md#teamsidportalsnkdesignfolderspost) | **POST** /Teams/{id}/portals/{nk}/designFolders | Creates a new instance in designFolders of this model.
[**TeamsIdPortalsNkDesignsCountGet**](TeamApi.md#teamsidportalsnkdesignscountget) | **GET** /Teams/{id}/portals/{nk}/designs/count | Counts designs of Portal.
[**TeamsIdPortalsNkDesignsDelete**](TeamApi.md#teamsidportalsnkdesignsdelete) | **DELETE** /Teams/{id}/portals/{nk}/designs | Deletes all designs of this model.
[**TeamsIdPortalsNkDesignsFkDelete**](TeamApi.md#teamsidportalsnkdesignsfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/designs/{fk} | Delete a related item by id for designs.
[**TeamsIdPortalsNkDesignsFkGet**](TeamApi.md#teamsidportalsnkdesignsfkget) | **GET** /Teams/{id}/portals/{nk}/designs/{fk} | Find a related item by id for designs.
[**TeamsIdPortalsNkDesignsFkPut**](TeamApi.md#teamsidportalsnkdesignsfkput) | **PUT** /Teams/{id}/portals/{nk}/designs/{fk} | Update a related item by id for designs.
[**TeamsIdPortalsNkDesignsGet**](TeamApi.md#teamsidportalsnkdesignsget) | **GET** /Teams/{id}/portals/{nk}/designs | Queries designs of Portal.
[**TeamsIdPortalsNkDesignsPost**](TeamApi.md#teamsidportalsnkdesignspost) | **POST** /Teams/{id}/portals/{nk}/designs | Creates a new instance in designs of this model.
[**TeamsIdPortalsNkImageFoldersCountGet**](TeamApi.md#teamsidportalsnkimagefolderscountget) | **GET** /Teams/{id}/portals/{nk}/imageFolders/count | Counts imageFolders of Portal.
[**TeamsIdPortalsNkImageFoldersDelete**](TeamApi.md#teamsidportalsnkimagefoldersdelete) | **DELETE** /Teams/{id}/portals/{nk}/imageFolders | Deletes all imageFolders of this model.
[**TeamsIdPortalsNkImageFoldersFkDelete**](TeamApi.md#teamsidportalsnkimagefoldersfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/imageFolders/{fk} | Delete a related item by id for imageFolders.
[**TeamsIdPortalsNkImageFoldersFkGet**](TeamApi.md#teamsidportalsnkimagefoldersfkget) | **GET** /Teams/{id}/portals/{nk}/imageFolders/{fk} | Find a related item by id for imageFolders.
[**TeamsIdPortalsNkImageFoldersFkPut**](TeamApi.md#teamsidportalsnkimagefoldersfkput) | **PUT** /Teams/{id}/portals/{nk}/imageFolders/{fk} | Update a related item by id for imageFolders.
[**TeamsIdPortalsNkImageFoldersGet**](TeamApi.md#teamsidportalsnkimagefoldersget) | **GET** /Teams/{id}/portals/{nk}/imageFolders | Queries imageFolders of Portal.
[**TeamsIdPortalsNkImageFoldersPost**](TeamApi.md#teamsidportalsnkimagefolderspost) | **POST** /Teams/{id}/portals/{nk}/imageFolders | Creates a new instance in imageFolders of this model.
[**TeamsIdPortalsNkImageFoldersRelFkDelete**](TeamApi.md#teamsidportalsnkimagefoldersrelfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/imageFolders/rel/{fk} | Remove the imageFolders relation to an item by id.
[**TeamsIdPortalsNkImageFoldersRelFkHead**](TeamApi.md#teamsidportalsnkimagefoldersrelfkhead) | **HEAD** /Teams/{id}/portals/{nk}/imageFolders/rel/{fk} | Check the existence of imageFolders relation to an item by id.
[**TeamsIdPortalsNkImageFoldersRelFkPut**](TeamApi.md#teamsidportalsnkimagefoldersrelfkput) | **PUT** /Teams/{id}/portals/{nk}/imageFolders/rel/{fk} | Add a related item by id for imageFolders.
[**TeamsIdPortalsNkMembersCountGet**](TeamApi.md#teamsidportalsnkmemberscountget) | **GET** /Teams/{id}/portals/{nk}/members/count | Counts members of Portal.
[**TeamsIdPortalsNkMembersDelete**](TeamApi.md#teamsidportalsnkmembersdelete) | **DELETE** /Teams/{id}/portals/{nk}/members | Deletes all members of this model.
[**TeamsIdPortalsNkMembersFkDelete**](TeamApi.md#teamsidportalsnkmembersfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/members/{fk} | Delete a related item by id for members.
[**TeamsIdPortalsNkMembersFkGet**](TeamApi.md#teamsidportalsnkmembersfkget) | **GET** /Teams/{id}/portals/{nk}/members/{fk} | Find a related item by id for members.
[**TeamsIdPortalsNkMembersFkPut**](TeamApi.md#teamsidportalsnkmembersfkput) | **PUT** /Teams/{id}/portals/{nk}/members/{fk} | Update a related item by id for members.
[**TeamsIdPortalsNkMembersGet**](TeamApi.md#teamsidportalsnkmembersget) | **GET** /Teams/{id}/portals/{nk}/members | Queries members of Portal.
[**TeamsIdPortalsNkMembersPost**](TeamApi.md#teamsidportalsnkmemberspost) | **POST** /Teams/{id}/portals/{nk}/members | Creates a new instance in members of this model.
[**TeamsIdPortalsNkMembersRelFkDelete**](TeamApi.md#teamsidportalsnkmembersrelfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/members/rel/{fk} | Remove the members relation to an item by id.
[**TeamsIdPortalsNkMembersRelFkHead**](TeamApi.md#teamsidportalsnkmembersrelfkhead) | **HEAD** /Teams/{id}/portals/{nk}/members/rel/{fk} | Check the existence of members relation to an item by id.
[**TeamsIdPortalsNkMembersRelFkPut**](TeamApi.md#teamsidportalsnkmembersrelfkput) | **PUT** /Teams/{id}/portals/{nk}/members/rel/{fk} | Add a related item by id for members.
[**TeamsIdPortalsNkPermissionDelete**](TeamApi.md#teamsidportalsnkpermissiondelete) | **DELETE** /Teams/{id}/portals/{nk}/permission | Deletes permission of this model.
[**TeamsIdPortalsNkPermissionGet**](TeamApi.md#teamsidportalsnkpermissionget) | **GET** /Teams/{id}/portals/{nk}/permission | Fetches hasOne relation permission.
[**TeamsIdPortalsNkPermissionPost**](TeamApi.md#teamsidportalsnkpermissionpost) | **POST** /Teams/{id}/portals/{nk}/permission | Creates a new instance in permission of this model.
[**TeamsIdPortalsNkPermissionPut**](TeamApi.md#teamsidportalsnkpermissionput) | **PUT** /Teams/{id}/portals/{nk}/permission | Update permission of this model.
[**TeamsIdPortalsNkPortalMembersCountGet**](TeamApi.md#teamsidportalsnkportalmemberscountget) | **GET** /Teams/{id}/portals/{nk}/portalMembers/count | Counts portalMembers of Portal.
[**TeamsIdPortalsNkPortalMembersDelete**](TeamApi.md#teamsidportalsnkportalmembersdelete) | **DELETE** /Teams/{id}/portals/{nk}/portalMembers | Deletes all portalMembers of this model.
[**TeamsIdPortalsNkPortalMembersFkDelete**](TeamApi.md#teamsidportalsnkportalmembersfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/portalMembers/{fk} | Delete a related item by id for portalMembers.
[**TeamsIdPortalsNkPortalMembersFkGet**](TeamApi.md#teamsidportalsnkportalmembersfkget) | **GET** /Teams/{id}/portals/{nk}/portalMembers/{fk} | Find a related item by id for portalMembers.
[**TeamsIdPortalsNkPortalMembersFkPut**](TeamApi.md#teamsidportalsnkportalmembersfkput) | **PUT** /Teams/{id}/portals/{nk}/portalMembers/{fk} | Update a related item by id for portalMembers.
[**TeamsIdPortalsNkPortalMembersGet**](TeamApi.md#teamsidportalsnkportalmembersget) | **GET** /Teams/{id}/portals/{nk}/portalMembers | Queries portalMembers of Portal.
[**TeamsIdPortalsNkPortalMembersPost**](TeamApi.md#teamsidportalsnkportalmemberspost) | **POST** /Teams/{id}/portals/{nk}/portalMembers | Creates a new instance in portalMembers of this model.
[**TeamsIdPortalsNkTeamGet**](TeamApi.md#teamsidportalsnkteamget) | **GET** /Teams/{id}/portals/{nk}/team | Fetches belongsTo relation team.
[**TeamsIdPortalsNkTemplateFoldersCountGet**](TeamApi.md#teamsidportalsnktemplatefolderscountget) | **GET** /Teams/{id}/portals/{nk}/templateFolders/count | Counts templateFolders of Portal.
[**TeamsIdPortalsNkTemplateFoldersDelete**](TeamApi.md#teamsidportalsnktemplatefoldersdelete) | **DELETE** /Teams/{id}/portals/{nk}/templateFolders | Deletes all templateFolders of this model.
[**TeamsIdPortalsNkTemplateFoldersFkDelete**](TeamApi.md#teamsidportalsnktemplatefoldersfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/templateFolders/{fk} | Delete a related item by id for templateFolders.
[**TeamsIdPortalsNkTemplateFoldersFkGet**](TeamApi.md#teamsidportalsnktemplatefoldersfkget) | **GET** /Teams/{id}/portals/{nk}/templateFolders/{fk} | Find a related item by id for templateFolders.
[**TeamsIdPortalsNkTemplateFoldersFkPut**](TeamApi.md#teamsidportalsnktemplatefoldersfkput) | **PUT** /Teams/{id}/portals/{nk}/templateFolders/{fk} | Update a related item by id for templateFolders.
[**TeamsIdPortalsNkTemplateFoldersGet**](TeamApi.md#teamsidportalsnktemplatefoldersget) | **GET** /Teams/{id}/portals/{nk}/templateFolders | Queries templateFolders of Portal.
[**TeamsIdPortalsNkTemplateFoldersPost**](TeamApi.md#teamsidportalsnktemplatefolderspost) | **POST** /Teams/{id}/portals/{nk}/templateFolders | Creates a new instance in templateFolders of this model.
[**TeamsIdPortalsNkTemplateRelsCountGet**](TeamApi.md#teamsidportalsnktemplaterelscountget) | **GET** /Teams/{id}/portals/{nk}/templateRels/count | Counts templateRels of Portal.
[**TeamsIdPortalsNkTemplateRelsDelete**](TeamApi.md#teamsidportalsnktemplaterelsdelete) | **DELETE** /Teams/{id}/portals/{nk}/templateRels | Deletes all templateRels of this model.
[**TeamsIdPortalsNkTemplateRelsFkDelete**](TeamApi.md#teamsidportalsnktemplaterelsfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/templateRels/{fk} | Delete a related item by id for templateRels.
[**TeamsIdPortalsNkTemplateRelsFkGet**](TeamApi.md#teamsidportalsnktemplaterelsfkget) | **GET** /Teams/{id}/portals/{nk}/templateRels/{fk} | Find a related item by id for templateRels.
[**TeamsIdPortalsNkTemplateRelsFkPut**](TeamApi.md#teamsidportalsnktemplaterelsfkput) | **PUT** /Teams/{id}/portals/{nk}/templateRels/{fk} | Update a related item by id for templateRels.
[**TeamsIdPortalsNkTemplateRelsGet**](TeamApi.md#teamsidportalsnktemplaterelsget) | **GET** /Teams/{id}/portals/{nk}/templateRels | Queries templateRels of Portal.
[**TeamsIdPortalsNkTemplateRelsPost**](TeamApi.md#teamsidportalsnktemplaterelspost) | **POST** /Teams/{id}/portals/{nk}/templateRels | Creates a new instance in templateRels of this model.
[**TeamsIdPortalsNkTemplatesCountGet**](TeamApi.md#teamsidportalsnktemplatescountget) | **GET** /Teams/{id}/portals/{nk}/templates/count | Counts templates of Portal.
[**TeamsIdPortalsNkTemplatesDelete**](TeamApi.md#teamsidportalsnktemplatesdelete) | **DELETE** /Teams/{id}/portals/{nk}/templates | Deletes all templates of this model.
[**TeamsIdPortalsNkTemplatesFkDelete**](TeamApi.md#teamsidportalsnktemplatesfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/templates/{fk} | Delete a related item by id for templates.
[**TeamsIdPortalsNkTemplatesFkGet**](TeamApi.md#teamsidportalsnktemplatesfkget) | **GET** /Teams/{id}/portals/{nk}/templates/{fk} | Find a related item by id for templates.
[**TeamsIdPortalsNkTemplatesFkPut**](TeamApi.md#teamsidportalsnktemplatesfkput) | **PUT** /Teams/{id}/portals/{nk}/templates/{fk} | Update a related item by id for templates.
[**TeamsIdPortalsNkTemplatesGet**](TeamApi.md#teamsidportalsnktemplatesget) | **GET** /Teams/{id}/portals/{nk}/templates | Queries templates of Portal.
[**TeamsIdPortalsNkTemplatesPost**](TeamApi.md#teamsidportalsnktemplatespost) | **POST** /Teams/{id}/portals/{nk}/templates | Creates a new instance in templates of this model.
[**TeamsIdPortalsNkTemplatesRelFkDelete**](TeamApi.md#teamsidportalsnktemplatesrelfkdelete) | **DELETE** /Teams/{id}/portals/{nk}/templates/rel/{fk} | Remove the templates relation to an item by id.
[**TeamsIdPortalsNkTemplatesRelFkHead**](TeamApi.md#teamsidportalsnktemplatesrelfkhead) | **HEAD** /Teams/{id}/portals/{nk}/templates/rel/{fk} | Check the existence of templates relation to an item by id.
[**TeamsIdPortalsNkTemplatesRelFkPut**](TeamApi.md#teamsidportalsnktemplatesrelfkput) | **PUT** /Teams/{id}/portals/{nk}/templates/rel/{fk} | Add a related item by id for templates.
[**TeamsIdPortalsPost**](TeamApi.md#teamsidportalspost) | **POST** /Teams/{id}/portals | Creates a new instance in portals of this model.
[**TeamsIdPut**](TeamApi.md#teamsidput) | **PUT** /Teams/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamsIdReplacePost**](TeamApi.md#teamsidreplacepost) | **POST** /Teams/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamsIdTeamMembersCountGet**](TeamApi.md#teamsidteammemberscountget) | **GET** /Teams/{id}/teamMembers/count | Counts teamMembers of Team.
[**TeamsIdTeamMembersDelete**](TeamApi.md#teamsidteammembersdelete) | **DELETE** /Teams/{id}/teamMembers | Deletes all teamMembers of this model.
[**TeamsIdTeamMembersFkDelete**](TeamApi.md#teamsidteammembersfkdelete) | **DELETE** /Teams/{id}/teamMembers/{fk} | Delete a related item by id for teamMembers.
[**TeamsIdTeamMembersFkGet**](TeamApi.md#teamsidteammembersfkget) | **GET** /Teams/{id}/teamMembers/{fk} | Find a related item by id for teamMembers.
[**TeamsIdTeamMembersFkPut**](TeamApi.md#teamsidteammembersfkput) | **PUT** /Teams/{id}/teamMembers/{fk} | Update a related item by id for teamMembers.
[**TeamsIdTeamMembersGet**](TeamApi.md#teamsidteammembersget) | **GET** /Teams/{id}/teamMembers | Queries teamMembers of Team.
[**TeamsIdTeamMembersPost**](TeamApi.md#teamsidteammemberspost) | **POST** /Teams/{id}/teamMembers | Creates a new instance in teamMembers of this model.
[**TeamsIdTemplateFoldersCountGet**](TeamApi.md#teamsidtemplatefolderscountget) | **GET** /Teams/{id}/templateFolders/count | Counts templateFolders of Team.
[**TeamsIdTemplateFoldersDelete**](TeamApi.md#teamsidtemplatefoldersdelete) | **DELETE** /Teams/{id}/templateFolders | Deletes all templateFolders of this model.
[**TeamsIdTemplateFoldersFkDelete**](TeamApi.md#teamsidtemplatefoldersfkdelete) | **DELETE** /Teams/{id}/templateFolders/{fk} | Delete a related item by id for templateFolders.
[**TeamsIdTemplateFoldersFkGet**](TeamApi.md#teamsidtemplatefoldersfkget) | **GET** /Teams/{id}/templateFolders/{fk} | Find a related item by id for templateFolders.
[**TeamsIdTemplateFoldersFkPut**](TeamApi.md#teamsidtemplatefoldersfkput) | **PUT** /Teams/{id}/templateFolders/{fk} | Update a related item by id for templateFolders.
[**TeamsIdTemplateFoldersGet**](TeamApi.md#teamsidtemplatefoldersget) | **GET** /Teams/{id}/templateFolders | Queries templateFolders of Team.
[**TeamsIdTemplateFoldersPost**](TeamApi.md#teamsidtemplatefolderspost) | **POST** /Teams/{id}/templateFolders | Creates a new instance in templateFolders of this model.
[**TeamsIdTemplatesCountGet**](TeamApi.md#teamsidtemplatescountget) | **GET** /Teams/{id}/templates/count | Counts templates of Team.
[**TeamsIdTemplatesDelete**](TeamApi.md#teamsidtemplatesdelete) | **DELETE** /Teams/{id}/templates | Deletes all templates of this model.
[**TeamsIdTemplatesFkDelete**](TeamApi.md#teamsidtemplatesfkdelete) | **DELETE** /Teams/{id}/templates/{fk} | Delete a related item by id for templates.
[**TeamsIdTemplatesFkGet**](TeamApi.md#teamsidtemplatesfkget) | **GET** /Teams/{id}/templates/{fk} | Find a related item by id for templates.
[**TeamsIdTemplatesFkPut**](TeamApi.md#teamsidtemplatesfkput) | **PUT** /Teams/{id}/templates/{fk} | Update a related item by id for templates.
[**TeamsIdTemplatesGet**](TeamApi.md#teamsidtemplatesget) | **GET** /Teams/{id}/templates | Queries templates of Team.
[**TeamsIdTemplatesNkDesignsCountGet**](TeamApi.md#teamsidtemplatesnkdesignscountget) | **GET** /Teams/{id}/templates/{nk}/designs/count | Counts designs of Template.
[**TeamsIdTemplatesNkDesignsDelete**](TeamApi.md#teamsidtemplatesnkdesignsdelete) | **DELETE** /Teams/{id}/templates/{nk}/designs | Deletes all designs of this model.
[**TeamsIdTemplatesNkDesignsFkDelete**](TeamApi.md#teamsidtemplatesnkdesignsfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/designs/{fk} | Delete a related item by id for designs.
[**TeamsIdTemplatesNkDesignsFkGet**](TeamApi.md#teamsidtemplatesnkdesignsfkget) | **GET** /Teams/{id}/templates/{nk}/designs/{fk} | Find a related item by id for designs.
[**TeamsIdTemplatesNkDesignsFkPut**](TeamApi.md#teamsidtemplatesnkdesignsfkput) | **PUT** /Teams/{id}/templates/{nk}/designs/{fk} | Update a related item by id for designs.
[**TeamsIdTemplatesNkDesignsGet**](TeamApi.md#teamsidtemplatesnkdesignsget) | **GET** /Teams/{id}/templates/{nk}/designs | Queries designs of Template.
[**TeamsIdTemplatesNkDesignsPost**](TeamApi.md#teamsidtemplatesnkdesignspost) | **POST** /Teams/{id}/templates/{nk}/designs | Creates a new instance in designs of this model.
[**TeamsIdTemplatesNkMembersCountGet**](TeamApi.md#teamsidtemplatesnkmemberscountget) | **GET** /Teams/{id}/templates/{nk}/members/count | Counts members of Template.
[**TeamsIdTemplatesNkMembersDelete**](TeamApi.md#teamsidtemplatesnkmembersdelete) | **DELETE** /Teams/{id}/templates/{nk}/members | Deletes all members of this model.
[**TeamsIdTemplatesNkMembersFkDelete**](TeamApi.md#teamsidtemplatesnkmembersfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/members/{fk} | Delete a related item by id for members.
[**TeamsIdTemplatesNkMembersFkGet**](TeamApi.md#teamsidtemplatesnkmembersfkget) | **GET** /Teams/{id}/templates/{nk}/members/{fk} | Find a related item by id for members.
[**TeamsIdTemplatesNkMembersFkPut**](TeamApi.md#teamsidtemplatesnkmembersfkput) | **PUT** /Teams/{id}/templates/{nk}/members/{fk} | Update a related item by id for members.
[**TeamsIdTemplatesNkMembersGet**](TeamApi.md#teamsidtemplatesnkmembersget) | **GET** /Teams/{id}/templates/{nk}/members | Queries members of Template.
[**TeamsIdTemplatesNkMembersPost**](TeamApi.md#teamsidtemplatesnkmemberspost) | **POST** /Teams/{id}/templates/{nk}/members | Creates a new instance in members of this model.
[**TeamsIdTemplatesNkMembersRelFkDelete**](TeamApi.md#teamsidtemplatesnkmembersrelfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/members/rel/{fk} | Remove the members relation to an item by id.
[**TeamsIdTemplatesNkMembersRelFkHead**](TeamApi.md#teamsidtemplatesnkmembersrelfkhead) | **HEAD** /Teams/{id}/templates/{nk}/members/rel/{fk} | Check the existence of members relation to an item by id.
[**TeamsIdTemplatesNkMembersRelFkPut**](TeamApi.md#teamsidtemplatesnkmembersrelfkput) | **PUT** /Teams/{id}/templates/{nk}/members/rel/{fk} | Add a related item by id for members.
[**TeamsIdTemplatesNkPermissionDelete**](TeamApi.md#teamsidtemplatesnkpermissiondelete) | **DELETE** /Teams/{id}/templates/{nk}/permission | Deletes permission of this model.
[**TeamsIdTemplatesNkPermissionGet**](TeamApi.md#teamsidtemplatesnkpermissionget) | **GET** /Teams/{id}/templates/{nk}/permission | Fetches hasOne relation permission.
[**TeamsIdTemplatesNkPermissionPost**](TeamApi.md#teamsidtemplatesnkpermissionpost) | **POST** /Teams/{id}/templates/{nk}/permission | Creates a new instance in permission of this model.
[**TeamsIdTemplatesNkPermissionPut**](TeamApi.md#teamsidtemplatesnkpermissionput) | **PUT** /Teams/{id}/templates/{nk}/permission | Update permission of this model.
[**TeamsIdTemplatesNkPortalFoldersCountGet**](TeamApi.md#teamsidtemplatesnkportalfolderscountget) | **GET** /Teams/{id}/templates/{nk}/portalFolders/count | Counts portalFolders of Template.
[**TeamsIdTemplatesNkPortalFoldersDelete**](TeamApi.md#teamsidtemplatesnkportalfoldersdelete) | **DELETE** /Teams/{id}/templates/{nk}/portalFolders | Deletes all portalFolders of this model.
[**TeamsIdTemplatesNkPortalFoldersFkDelete**](TeamApi.md#teamsidtemplatesnkportalfoldersfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/portalFolders/{fk} | Delete a related item by id for portalFolders.
[**TeamsIdTemplatesNkPortalFoldersFkGet**](TeamApi.md#teamsidtemplatesnkportalfoldersfkget) | **GET** /Teams/{id}/templates/{nk}/portalFolders/{fk} | Find a related item by id for portalFolders.
[**TeamsIdTemplatesNkPortalFoldersFkPut**](TeamApi.md#teamsidtemplatesnkportalfoldersfkput) | **PUT** /Teams/{id}/templates/{nk}/portalFolders/{fk} | Update a related item by id for portalFolders.
[**TeamsIdTemplatesNkPortalFoldersGet**](TeamApi.md#teamsidtemplatesnkportalfoldersget) | **GET** /Teams/{id}/templates/{nk}/portalFolders | Queries portalFolders of Template.
[**TeamsIdTemplatesNkPortalFoldersPost**](TeamApi.md#teamsidtemplatesnkportalfolderspost) | **POST** /Teams/{id}/templates/{nk}/portalFolders | Creates a new instance in portalFolders of this model.
[**TeamsIdTemplatesNkPortalFoldersRelFkDelete**](TeamApi.md#teamsidtemplatesnkportalfoldersrelfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/portalFolders/rel/{fk} | Remove the portalFolders relation to an item by id.
[**TeamsIdTemplatesNkPortalFoldersRelFkHead**](TeamApi.md#teamsidtemplatesnkportalfoldersrelfkhead) | **HEAD** /Teams/{id}/templates/{nk}/portalFolders/rel/{fk} | Check the existence of portalFolders relation to an item by id.
[**TeamsIdTemplatesNkPortalFoldersRelFkPut**](TeamApi.md#teamsidtemplatesnkportalfoldersrelfkput) | **PUT** /Teams/{id}/templates/{nk}/portalFolders/rel/{fk} | Add a related item by id for portalFolders.
[**TeamsIdTemplatesNkPortalsCountGet**](TeamApi.md#teamsidtemplatesnkportalscountget) | **GET** /Teams/{id}/templates/{nk}/portals/count | Counts portals of Template.
[**TeamsIdTemplatesNkPortalsDelete**](TeamApi.md#teamsidtemplatesnkportalsdelete) | **DELETE** /Teams/{id}/templates/{nk}/portals | Deletes all portals of this model.
[**TeamsIdTemplatesNkPortalsFkDelete**](TeamApi.md#teamsidtemplatesnkportalsfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/portals/{fk} | Delete a related item by id for portals.
[**TeamsIdTemplatesNkPortalsFkGet**](TeamApi.md#teamsidtemplatesnkportalsfkget) | **GET** /Teams/{id}/templates/{nk}/portals/{fk} | Find a related item by id for portals.
[**TeamsIdTemplatesNkPortalsFkPut**](TeamApi.md#teamsidtemplatesnkportalsfkput) | **PUT** /Teams/{id}/templates/{nk}/portals/{fk} | Update a related item by id for portals.
[**TeamsIdTemplatesNkPortalsGet**](TeamApi.md#teamsidtemplatesnkportalsget) | **GET** /Teams/{id}/templates/{nk}/portals | Queries portals of Template.
[**TeamsIdTemplatesNkPortalsPost**](TeamApi.md#teamsidtemplatesnkportalspost) | **POST** /Teams/{id}/templates/{nk}/portals | Creates a new instance in portals of this model.
[**TeamsIdTemplatesNkPortalsRelFkDelete**](TeamApi.md#teamsidtemplatesnkportalsrelfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/portals/rel/{fk} | Remove the portals relation to an item by id.
[**TeamsIdTemplatesNkPortalsRelFkHead**](TeamApi.md#teamsidtemplatesnkportalsrelfkhead) | **HEAD** /Teams/{id}/templates/{nk}/portals/rel/{fk} | Check the existence of portals relation to an item by id.
[**TeamsIdTemplatesNkPortalsRelFkPut**](TeamApi.md#teamsidtemplatesnkportalsrelfkput) | **PUT** /Teams/{id}/templates/{nk}/portals/rel/{fk} | Add a related item by id for portals.
[**TeamsIdTemplatesNkTagsCountGet**](TeamApi.md#teamsidtemplatesnktagscountget) | **GET** /Teams/{id}/templates/{nk}/tags/count | Counts tags of Template.
[**TeamsIdTemplatesNkTagsDelete**](TeamApi.md#teamsidtemplatesnktagsdelete) | **DELETE** /Teams/{id}/templates/{nk}/tags | Deletes all tags of this model.
[**TeamsIdTemplatesNkTagsFkDelete**](TeamApi.md#teamsidtemplatesnktagsfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/tags/{fk} | Delete a related item by id for tags.
[**TeamsIdTemplatesNkTagsFkGet**](TeamApi.md#teamsidtemplatesnktagsfkget) | **GET** /Teams/{id}/templates/{nk}/tags/{fk} | Find a related item by id for tags.
[**TeamsIdTemplatesNkTagsFkPut**](TeamApi.md#teamsidtemplatesnktagsfkput) | **PUT** /Teams/{id}/templates/{nk}/tags/{fk} | Update a related item by id for tags.
[**TeamsIdTemplatesNkTagsGet**](TeamApi.md#teamsidtemplatesnktagsget) | **GET** /Teams/{id}/templates/{nk}/tags | Queries tags of Template.
[**TeamsIdTemplatesNkTagsPost**](TeamApi.md#teamsidtemplatesnktagspost) | **POST** /Teams/{id}/templates/{nk}/tags | Creates a new instance in tags of this model.
[**TeamsIdTemplatesNkTagsRelFkDelete**](TeamApi.md#teamsidtemplatesnktagsrelfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/tags/rel/{fk} | Remove the tags relation to an item by id.
[**TeamsIdTemplatesNkTagsRelFkHead**](TeamApi.md#teamsidtemplatesnktagsrelfkhead) | **HEAD** /Teams/{id}/templates/{nk}/tags/rel/{fk} | Check the existence of tags relation to an item by id.
[**TeamsIdTemplatesNkTagsRelFkPut**](TeamApi.md#teamsidtemplatesnktagsrelfkput) | **PUT** /Teams/{id}/templates/{nk}/tags/rel/{fk} | Add a related item by id for tags.
[**TeamsIdTemplatesNkTeamFolderGet**](TeamApi.md#teamsidtemplatesnkteamfolderget) | **GET** /Teams/{id}/templates/{nk}/teamFolder | Fetches belongsTo relation teamFolder.
[**TeamsIdTemplatesNkTeamGet**](TeamApi.md#teamsidtemplatesnkteamget) | **GET** /Teams/{id}/templates/{nk}/team | Fetches belongsTo relation team.
[**TeamsIdTemplatesNkTemplateMembersCountGet**](TeamApi.md#teamsidtemplatesnktemplatememberscountget) | **GET** /Teams/{id}/templates/{nk}/templateMembers/count | Counts templateMembers of Template.
[**TeamsIdTemplatesNkTemplateMembersDelete**](TeamApi.md#teamsidtemplatesnktemplatemembersdelete) | **DELETE** /Teams/{id}/templates/{nk}/templateMembers | Deletes all templateMembers of this model.
[**TeamsIdTemplatesNkTemplateMembersFkDelete**](TeamApi.md#teamsidtemplatesnktemplatemembersfkdelete) | **DELETE** /Teams/{id}/templates/{nk}/templateMembers/{fk} | Delete a related item by id for templateMembers.
[**TeamsIdTemplatesNkTemplateMembersFkGet**](TeamApi.md#teamsidtemplatesnktemplatemembersfkget) | **GET** /Teams/{id}/templates/{nk}/templateMembers/{fk} | Find a related item by id for templateMembers.
[**TeamsIdTemplatesNkTemplateMembersFkPut**](TeamApi.md#teamsidtemplatesnktemplatemembersfkput) | **PUT** /Teams/{id}/templates/{nk}/templateMembers/{fk} | Update a related item by id for templateMembers.
[**TeamsIdTemplatesNkTemplateMembersGet**](TeamApi.md#teamsidtemplatesnktemplatemembersget) | **GET** /Teams/{id}/templates/{nk}/templateMembers | Queries templateMembers of Template.
[**TeamsIdTemplatesNkTemplateMembersPost**](TeamApi.md#teamsidtemplatesnktemplatememberspost) | **POST** /Teams/{id}/templates/{nk}/templateMembers | Creates a new instance in templateMembers of this model.
[**TeamsIdTemplatesNkUploaderGet**](TeamApi.md#teamsidtemplatesnkuploaderget) | **GET** /Teams/{id}/templates/{nk}/uploader | Fetches belongsTo relation uploader.
[**TeamsIdTemplatesNkWorkflowGet**](TeamApi.md#teamsidtemplatesnkworkflowget) | **GET** /Teams/{id}/templates/{nk}/workflow | Fetches belongsTo relation workflow.
[**TeamsIdTemplatesPost**](TeamApi.md#teamsidtemplatespost) | **POST** /Teams/{id}/templates | Creates a new instance in templates of this model.
[**TeamsIdTemplatesWithDesignsGet**](TeamApi.md#teamsidtemplateswithdesignsget) | **GET** /Teams/{id}/templatesWithDesigns | List Templates with Designs for this Team
[**TeamsIdWorkflowsCountGet**](TeamApi.md#teamsidworkflowscountget) | **GET** /Teams/{id}/workflows/count | Counts workflows of Team.
[**TeamsIdWorkflowsDelete**](TeamApi.md#teamsidworkflowsdelete) | **DELETE** /Teams/{id}/workflows | Deletes all workflows of this model.
[**TeamsIdWorkflowsFkDelete**](TeamApi.md#teamsidworkflowsfkdelete) | **DELETE** /Teams/{id}/workflows/{fk} | Delete a related item by id for workflows.
[**TeamsIdWorkflowsFkGet**](TeamApi.md#teamsidworkflowsfkget) | **GET** /Teams/{id}/workflows/{fk} | Find a related item by id for workflows.
[**TeamsIdWorkflowsFkPut**](TeamApi.md#teamsidworkflowsfkput) | **PUT** /Teams/{id}/workflows/{fk} | Update a related item by id for workflows.
[**TeamsIdWorkflowsGet**](TeamApi.md#teamsidworkflowsget) | **GET** /Teams/{id}/workflows | Queries workflows of Team.
[**TeamsIdWorkflowsPost**](TeamApi.md#teamsidworkflowspost) | **POST** /Teams/{id}/workflows | Creates a new instance in workflows of this model.
[**TeamsNameNameExistsGet**](TeamApi.md#teamsnamenameexistsget) | **GET** /Teams/name/{name}/exists | Define whether team exists or not
[**TeamsPatch**](TeamApi.md#teamspatch) | **PATCH** /Teams | Patch an existing model instance or insert a new one into the data source.
[**TeamsPost**](TeamApi.md#teamspost) | **POST** /Teams | Create a new instance of the model and persist it into the data source.
[**TeamsPut**](TeamApi.md#teamsput) | **PUT** /Teams | Replace an existing model instance or insert a new one into the data source.
[**TeamsReplaceOrCreatePost**](TeamApi.md#teamsreplaceorcreatepost) | **POST** /Teams/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamsSubdomainSubdomainExistsGet**](TeamApi.md#teamssubdomainsubdomainexistsget) | **GET** /Teams/subdomain/{subdomain}/exists | Define whether team exists or not
[**TeamsUpdatePost**](TeamApi.md#teamsupdatepost) | **POST** /Teams/update | Update instances of the model matched by {{where}} from the data source.
[**TeamsUpsertWithWherePost**](TeamApi.md#teamsupsertwithwherepost) | **POST** /Teams/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teamschangestreamget"></a>
# **TeamsChangeStreamGet**
> System.IO.Stream TeamsChangeStreamGet (string options = null)

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
    public class TeamsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsChangeStreamGet: " + e.Message );
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

<a name="teamschangestreampost"></a>
# **TeamsChangeStreamPost**
> System.IO.Stream TeamsChangeStreamPost (string options = null)

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
    public class TeamsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsChangeStreamPost: " + e.Message );
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

<a name="teamscountget"></a>
# **TeamsCountGet**
> InlineResponse200 TeamsCountGet (string where = null)

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
    public class TeamsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.TeamsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsCountGet: " + e.Message );
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

<a name="teamsfindoneget"></a>
# **TeamsFindOneGet**
> Team TeamsFindOneGet (string filter = null)

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
    public class TeamsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                Team result = apiInstance.TeamsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsFindOneGet: " + e.Message );
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

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsget"></a>
# **TeamsGet**
> List<Team> TeamsGet (string filter = null)

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
    public class TeamsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;Team&gt; result = apiInstance.TeamsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsGet: " + e.Message );
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

[**List<Team>**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidbillingdelete"></a>
# **TeamsIdBillingDelete**
> void TeamsIdBillingDelete (string id)

Deletes billing of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdBillingDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes billing of this model.
                apiInstance.TeamsIdBillingDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdBillingDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidbillingget"></a>
# **TeamsIdBillingGet**
> Billing TeamsIdBillingGet (string id, bool? refresh = null)

Fetches hasOne relation billing.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdBillingGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation billing.
                Billing result = apiInstance.TeamsIdBillingGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdBillingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidbillingpost"></a>
# **TeamsIdBillingPost**
> Billing TeamsIdBillingPost (string id, Billing data = null)

Creates a new instance in billing of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdBillingPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new Billing(); // Billing |  (optional) 

            try
            {
                // Creates a new instance in billing of this model.
                Billing result = apiInstance.TeamsIdBillingPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdBillingPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**Billing**](Billing.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidbillingput"></a>
# **TeamsIdBillingPut**
> Billing TeamsIdBillingPut (string id, Billing data = null)

Update billing of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdBillingPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new Billing(); // Billing |  (optional) 

            try
            {
                // Update billing of this model.
                Billing result = apiInstance.TeamsIdBillingPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdBillingPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**Billing**](Billing.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidbranddelete"></a>
# **TeamsIdBrandDelete**
> void TeamsIdBrandDelete (string id)

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
    public class TeamsIdBrandDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes brand of this model.
                apiInstance.TeamsIdBrandDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdBrandDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidbrandget"></a>
# **TeamsIdBrandGet**
> TeamBrand TeamsIdBrandGet (string id, bool? refresh = null)

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
    public class TeamsIdBrandGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation brand.
                TeamBrand result = apiInstance.TeamsIdBrandGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdBrandGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidbrandpost"></a>
# **TeamsIdBrandPost**
> TeamBrand TeamsIdBrandPost (string id, TeamBrand data = null)

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
    public class TeamsIdBrandPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new TeamBrand(); // TeamBrand |  (optional) 

            try
            {
                // Creates a new instance in brand of this model.
                TeamBrand result = apiInstance.TeamsIdBrandPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdBrandPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**TeamBrand**](TeamBrand.md)|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidbrandput"></a>
# **TeamsIdBrandPut**
> TeamBrand TeamsIdBrandPut (string id, TeamBrand data = null)

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
    public class TeamsIdBrandPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new TeamBrand(); // TeamBrand |  (optional) 

            try
            {
                // Update brand of this model.
                TeamBrand result = apiInstance.TeamsIdBrandPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdBrandPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**TeamBrand**](TeamBrand.md)|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsiddatasourcescountget"></a>
# **TeamsIdDataSourcesCountGet**
> InlineResponse200 TeamsIdDataSourcesCountGet (string id, string where = null)

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
    public class TeamsIdDataSourcesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts dataSources of Team.
                InlineResponse200 result = apiInstance.TeamsIdDataSourcesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdDataSourcesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsiddatasourcesdelete"></a>
# **TeamsIdDataSourcesDelete**
> void TeamsIdDataSourcesDelete (string id)

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
    public class TeamsIdDataSourcesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all dataSources of this model.
                apiInstance.TeamsIdDataSourcesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdDataSourcesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsiddatasourcesfkdelete"></a>
# **TeamsIdDataSourcesFkDelete**
> void TeamsIdDataSourcesFkDelete (string id, string fk)

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
    public class TeamsIdDataSourcesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for dataSources

            try
            {
                // Delete a related item by id for dataSources.
                apiInstance.TeamsIdDataSourcesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdDataSourcesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for dataSources | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsiddatasourcesfkget"></a>
# **TeamsIdDataSourcesFkGet**
> DataSource TeamsIdDataSourcesFkGet (string id, string fk)

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
    public class TeamsIdDataSourcesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for dataSources

            try
            {
                // Find a related item by id for dataSources.
                DataSource result = apiInstance.TeamsIdDataSourcesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdDataSourcesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for dataSources | 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsiddatasourcesfkput"></a>
# **TeamsIdDataSourcesFkPut**
> DataSource TeamsIdDataSourcesFkPut (string id, string fk, DataSource data = null)

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
    public class TeamsIdDataSourcesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for dataSources
            var data = new DataSource(); // DataSource |  (optional) 

            try
            {
                // Update a related item by id for dataSources.
                DataSource result = apiInstance.TeamsIdDataSourcesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdDataSourcesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsiddatasourcesget"></a>
# **TeamsIdDataSourcesGet**
> List<DataSource> TeamsIdDataSourcesGet (string id, string filter = null)

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
    public class TeamsIdDataSourcesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries dataSources of Team.
                List&lt;DataSource&gt; result = apiInstance.TeamsIdDataSourcesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdDataSourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DataSource>**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsiddatasourcespost"></a>
# **TeamsIdDataSourcesPost**
> DataSource TeamsIdDataSourcesPost (string id, DataSource data = null)

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
    public class TeamsIdDataSourcesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new DataSource(); // DataSource |  (optional) 

            try
            {
                // Creates a new instance in dataSources of this model.
                DataSource result = apiInstance.TeamsIdDataSourcesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdDataSourcesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**DataSource**](DataSource.md)|  | [optional] 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsiddelete"></a>
# **TeamsIdDelete**
> Object TeamsIdDelete (string id)

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
    public class TeamsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdDelete: " + e.Message );
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

<a name="teamsidexistsget"></a>
# **TeamsIdExistsGet**
> InlineResponse2001 TeamsIdExistsGet (string id)

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
    public class TeamsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.TeamsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdExistsGet: " + e.Message );
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

<a name="teamsidget"></a>
# **TeamsIdGet**
> Team TeamsIdGet (string id, string filter = null)

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
    public class TeamsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                Team result = apiInstance.TeamsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdGet: " + e.Message );
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

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidhead"></a>
# **TeamsIdHead**
> InlineResponse2001 TeamsIdHead (string id)

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
    public class TeamsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.TeamsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdHead: " + e.Message );
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

<a name="teamsidimagefolderscountget"></a>
# **TeamsIdImageFoldersCountGet**
> InlineResponse200 TeamsIdImageFoldersCountGet (string id, string where = null)

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
    public class TeamsIdImageFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts imageFolders of Team.
                InlineResponse200 result = apiInstance.TeamsIdImageFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersdelete"></a>
# **TeamsIdImageFoldersDelete**
> void TeamsIdImageFoldersDelete (string id)

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
    public class TeamsIdImageFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all imageFolders of this model.
                apiInstance.TeamsIdImageFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersfkdelete"></a>
# **TeamsIdImageFoldersFkDelete**
> void TeamsIdImageFoldersFkDelete (string id, string fk)

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
    public class TeamsIdImageFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Delete a related item by id for imageFolders.
                apiInstance.TeamsIdImageFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersfkget"></a>
# **TeamsIdImageFoldersFkGet**
> ImageFolder TeamsIdImageFoldersFkGet (string id, string fk)

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
    public class TeamsIdImageFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Find a related item by id for imageFolders.
                ImageFolder result = apiInstance.TeamsIdImageFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersfkput"></a>
# **TeamsIdImageFoldersFkPut**
> ImageFolder TeamsIdImageFoldersFkPut (string id, string fk, ImageFolder data = null)

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
    public class TeamsIdImageFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Update a related item by id for imageFolders.
                ImageFolder result = apiInstance.TeamsIdImageFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidimagefoldersget"></a>
# **TeamsIdImageFoldersGet**
> List<ImageFolder> TeamsIdImageFoldersGet (string id, string filter = null)

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
    public class TeamsIdImageFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries imageFolders of Team.
                List&lt;ImageFolder&gt; result = apiInstance.TeamsIdImageFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ImageFolder>**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkchildrencountget"></a>
# **TeamsIdImageFoldersNkChildrenCountGet**
> InlineResponse200 TeamsIdImageFoldersNkChildrenCountGet (string id, string nk, string where = null)

Counts children of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkChildrenCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts children of ImageFolder.
                InlineResponse200 result = apiInstance.TeamsIdImageFoldersNkChildrenCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkChildrenCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkchildrendelete"></a>
# **TeamsIdImageFoldersNkChildrenDelete**
> void TeamsIdImageFoldersNkChildrenDelete (string id, string nk)

Deletes all children of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkChildrenDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.

            try
            {
                // Deletes all children of this model.
                apiInstance.TeamsIdImageFoldersNkChildrenDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkChildrenDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkchildrenfkdelete"></a>
# **TeamsIdImageFoldersNkChildrenFkDelete**
> void TeamsIdImageFoldersNkChildrenFkDelete (string id, string nk, string fk)

Delete a related item by id for children.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkChildrenFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for children

            try
            {
                // Delete a related item by id for children.
                apiInstance.TeamsIdImageFoldersNkChildrenFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkChildrenFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for children | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkchildrenfkget"></a>
# **TeamsIdImageFoldersNkChildrenFkGet**
> ImageFolder TeamsIdImageFoldersNkChildrenFkGet (string id, string nk, string fk)

Find a related item by id for children.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkChildrenFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for children

            try
            {
                // Find a related item by id for children.
                ImageFolder result = apiInstance.TeamsIdImageFoldersNkChildrenFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkChildrenFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for children | 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkchildrenfkput"></a>
# **TeamsIdImageFoldersNkChildrenFkPut**
> ImageFolder TeamsIdImageFoldersNkChildrenFkPut (string id, string nk, string fk, ImageFolder data = null)

Update a related item by id for children.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkChildrenFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for children
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Update a related item by id for children.
                ImageFolder result = apiInstance.TeamsIdImageFoldersNkChildrenFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkChildrenFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for children | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkchildrenget"></a>
# **TeamsIdImageFoldersNkChildrenGet**
> List<ImageFolder> TeamsIdImageFoldersNkChildrenGet (string id, string nk, string filter = null)

Queries children of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkChildrenGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries children of ImageFolder.
                List&lt;ImageFolder&gt; result = apiInstance.TeamsIdImageFoldersNkChildrenGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkChildrenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ImageFolder>**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkchildrenpost"></a>
# **TeamsIdImageFoldersNkChildrenPost**
> ImageFolder TeamsIdImageFoldersNkChildrenPost (string id, string nk, ImageFolder data = null)

Creates a new instance in children of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkChildrenPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Creates a new instance in children of this model.
                ImageFolder result = apiInstance.TeamsIdImageFoldersNkChildrenPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkChildrenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkfoldermemberscountget"></a>
# **TeamsIdImageFoldersNkFolderMembersCountGet**
> InlineResponse200 TeamsIdImageFoldersNkFolderMembersCountGet (string id, string nk, string where = null)

Counts folderMembers of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkFolderMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts folderMembers of ImageFolder.
                InlineResponse200 result = apiInstance.TeamsIdImageFoldersNkFolderMembersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkFolderMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkfoldermembersdelete"></a>
# **TeamsIdImageFoldersNkFolderMembersDelete**
> void TeamsIdImageFoldersNkFolderMembersDelete (string id, string nk)

Deletes all folderMembers of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkFolderMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.

            try
            {
                // Deletes all folderMembers of this model.
                apiInstance.TeamsIdImageFoldersNkFolderMembersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkFolderMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkfoldermembersfkdelete"></a>
# **TeamsIdImageFoldersNkFolderMembersFkDelete**
> void TeamsIdImageFoldersNkFolderMembersFkDelete (string id, string nk, string fk)

Delete a related item by id for folderMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkFolderMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for folderMembers

            try
            {
                // Delete a related item by id for folderMembers.
                apiInstance.TeamsIdImageFoldersNkFolderMembersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkFolderMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for folderMembers | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkfoldermembersfkget"></a>
# **TeamsIdImageFoldersNkFolderMembersFkGet**
> ImageFolderMember TeamsIdImageFoldersNkFolderMembersFkGet (string id, string nk, string fk)

Find a related item by id for folderMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkFolderMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for folderMembers

            try
            {
                // Find a related item by id for folderMembers.
                ImageFolderMember result = apiInstance.TeamsIdImageFoldersNkFolderMembersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkFolderMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for folderMembers | 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkfoldermembersfkput"></a>
# **TeamsIdImageFoldersNkFolderMembersFkPut**
> ImageFolderMember TeamsIdImageFoldersNkFolderMembersFkPut (string id, string nk, string fk, ImageFolderMember data = null)

Update a related item by id for folderMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkFolderMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for folderMembers
            var data = new ImageFolderMember(); // ImageFolderMember |  (optional) 

            try
            {
                // Update a related item by id for folderMembers.
                ImageFolderMember result = apiInstance.TeamsIdImageFoldersNkFolderMembersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkFolderMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for folderMembers | 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)|  | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkfoldermembersget"></a>
# **TeamsIdImageFoldersNkFolderMembersGet**
> List<ImageFolderMember> TeamsIdImageFoldersNkFolderMembersGet (string id, string nk, string filter = null)

Queries folderMembers of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkFolderMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries folderMembers of ImageFolder.
                List&lt;ImageFolderMember&gt; result = apiInstance.TeamsIdImageFoldersNkFolderMembersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkFolderMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ImageFolderMember>**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkfoldermemberspost"></a>
# **TeamsIdImageFoldersNkFolderMembersPost**
> ImageFolderMember TeamsIdImageFoldersNkFolderMembersPost (string id, string nk, ImageFolderMember data = null)

Creates a new instance in folderMembers of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkFolderMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var data = new ImageFolderMember(); // ImageFolderMember |  (optional) 

            try
            {
                // Creates a new instance in folderMembers of this model.
                ImageFolderMember result = apiInstance.TeamsIdImageFoldersNkFolderMembersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkFolderMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)|  | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkimagescountget"></a>
# **TeamsIdImageFoldersNkImagesCountGet**
> InlineResponse200 TeamsIdImageFoldersNkImagesCountGet (string id, string nk, string where = null)

Counts images of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkImagesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts images of ImageFolder.
                InlineResponse200 result = apiInstance.TeamsIdImageFoldersNkImagesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkImagesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkimagesdelete"></a>
# **TeamsIdImageFoldersNkImagesDelete**
> void TeamsIdImageFoldersNkImagesDelete (string id, string nk)

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
    public class TeamsIdImageFoldersNkImagesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.

            try
            {
                // Deletes all images of this model.
                apiInstance.TeamsIdImageFoldersNkImagesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkImagesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkimagesfkdelete"></a>
# **TeamsIdImageFoldersNkImagesFkDelete**
> void TeamsIdImageFoldersNkImagesFkDelete (string id, string nk, string fk)

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
    public class TeamsIdImageFoldersNkImagesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for images

            try
            {
                // Delete a related item by id for images.
                apiInstance.TeamsIdImageFoldersNkImagesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkImagesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for images | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkimagesfkget"></a>
# **TeamsIdImageFoldersNkImagesFkGet**
> Image TeamsIdImageFoldersNkImagesFkGet (string id, string nk, string fk)

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
    public class TeamsIdImageFoldersNkImagesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for images

            try
            {
                // Find a related item by id for images.
                Image result = apiInstance.TeamsIdImageFoldersNkImagesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkImagesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for images | 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkimagesfkput"></a>
# **TeamsIdImageFoldersNkImagesFkPut**
> Image TeamsIdImageFoldersNkImagesFkPut (string id, string nk, string fk, Image data = null)

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
    public class TeamsIdImageFoldersNkImagesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for images
            var data = new Image(); // Image |  (optional) 

            try
            {
                // Update a related item by id for images.
                Image result = apiInstance.TeamsIdImageFoldersNkImagesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkImagesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
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

<a name="teamsidimagefoldersnkimagesget"></a>
# **TeamsIdImageFoldersNkImagesGet**
> List<Image> TeamsIdImageFoldersNkImagesGet (string id, string nk, string filter = null)

Queries images of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkImagesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries images of ImageFolder.
                List&lt;Image&gt; result = apiInstance.TeamsIdImageFoldersNkImagesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkImagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Image>**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkimagespost"></a>
# **TeamsIdImageFoldersNkImagesPost**
> Image TeamsIdImageFoldersNkImagesPost (string id, string nk, Image data = null)

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
    public class TeamsIdImageFoldersNkImagesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var data = new Image(); // Image |  (optional) 

            try
            {
                // Creates a new instance in images of this model.
                Image result = apiInstance.TeamsIdImageFoldersNkImagesPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkImagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **data** | [**Image**](Image.md)|  | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmemberscountget"></a>
# **TeamsIdImageFoldersNkMembersCountGet**
> InlineResponse200 TeamsIdImageFoldersNkMembersCountGet (string id, string nk, string where = null)

Counts members of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts members of ImageFolder.
                InlineResponse200 result = apiInstance.TeamsIdImageFoldersNkMembersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmembersdelete"></a>
# **TeamsIdImageFoldersNkMembersDelete**
> void TeamsIdImageFoldersNkMembersDelete (string id, string nk)

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
    public class TeamsIdImageFoldersNkMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.

            try
            {
                // Deletes all members of this model.
                apiInstance.TeamsIdImageFoldersNkMembersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmembersfkdelete"></a>
# **TeamsIdImageFoldersNkMembersFkDelete**
> void TeamsIdImageFoldersNkMembersFkDelete (string id, string nk, string fk)

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
    public class TeamsIdImageFoldersNkMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Delete a related item by id for members.
                apiInstance.TeamsIdImageFoldersNkMembersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmembersfkget"></a>
# **TeamsIdImageFoldersNkMembersFkGet**
> TeamMember TeamsIdImageFoldersNkMembersFkGet (string id, string nk, string fk)

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
    public class TeamsIdImageFoldersNkMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Find a related item by id for members.
                TeamMember result = apiInstance.TeamsIdImageFoldersNkMembersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for members | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmembersfkput"></a>
# **TeamsIdImageFoldersNkMembersFkPut**
> TeamMember TeamsIdImageFoldersNkMembersFkPut (string id, string nk, string fk, TeamMember data = null)

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
    public class TeamsIdImageFoldersNkMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for members
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for members.
                TeamMember result = apiInstance.TeamsIdImageFoldersNkMembersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
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

<a name="teamsidimagefoldersnkmembersget"></a>
# **TeamsIdImageFoldersNkMembersGet**
> List<TeamMember> TeamsIdImageFoldersNkMembersGet (string id, string nk, string filter = null)

Queries members of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries members of ImageFolder.
                List&lt;TeamMember&gt; result = apiInstance.TeamsIdImageFoldersNkMembersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmemberspost"></a>
# **TeamsIdImageFoldersNkMembersPost**
> TeamMember TeamsIdImageFoldersNkMembersPost (string id, string nk, TeamMember data = null)

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
    public class TeamsIdImageFoldersNkMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in members of this model.
                TeamMember result = apiInstance.TeamsIdImageFoldersNkMembersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmembersrelfkdelete"></a>
# **TeamsIdImageFoldersNkMembersRelFkDelete**
> void TeamsIdImageFoldersNkMembersRelFkDelete (string id, string nk, string fk)

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
    public class TeamsIdImageFoldersNkMembersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Remove the members relation to an item by id.
                apiInstance.TeamsIdImageFoldersNkMembersRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmembersrelfkhead"></a>
# **TeamsIdImageFoldersNkMembersRelFkHead**
> bool? TeamsIdImageFoldersNkMembersRelFkHead (string id, string nk, string fk)

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
    public class TeamsIdImageFoldersNkMembersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Check the existence of members relation to an item by id.
                bool? result = apiInstance.TeamsIdImageFoldersNkMembersRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for members | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkmembersrelfkput"></a>
# **TeamsIdImageFoldersNkMembersRelFkPut**
> ImageFolderMember TeamsIdImageFoldersNkMembersRelFkPut (string id, string nk, string fk, ImageFolderMember data = null)

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
    public class TeamsIdImageFoldersNkMembersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for members
            var data = new ImageFolderMember(); // ImageFolderMember |  (optional) 

            try
            {
                // Add a related item by id for members.
                ImageFolderMember result = apiInstance.TeamsIdImageFoldersNkMembersRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkMembersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for members | 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)|  | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkparentget"></a>
# **TeamsIdImageFoldersNkParentGet**
> ImageFolder TeamsIdImageFoldersNkParentGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation parent.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkParentGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation parent.
                ImageFolder result = apiInstance.TeamsIdImageFoldersNkParentGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkParentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalscountget"></a>
# **TeamsIdImageFoldersNkPortalsCountGet**
> InlineResponse200 TeamsIdImageFoldersNkPortalsCountGet (string id, string nk, string where = null)

Counts portals of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkPortalsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portals of ImageFolder.
                InlineResponse200 result = apiInstance.TeamsIdImageFoldersNkPortalsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalsdelete"></a>
# **TeamsIdImageFoldersNkPortalsDelete**
> void TeamsIdImageFoldersNkPortalsDelete (string id, string nk)

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
    public class TeamsIdImageFoldersNkPortalsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.

            try
            {
                // Deletes all portals of this model.
                apiInstance.TeamsIdImageFoldersNkPortalsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalsfkdelete"></a>
# **TeamsIdImageFoldersNkPortalsFkDelete**
> void TeamsIdImageFoldersNkPortalsFkDelete (string id, string nk, string fk)

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
    public class TeamsIdImageFoldersNkPortalsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Delete a related item by id for portals.
                apiInstance.TeamsIdImageFoldersNkPortalsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalsfkget"></a>
# **TeamsIdImageFoldersNkPortalsFkGet**
> Portal TeamsIdImageFoldersNkPortalsFkGet (string id, string nk, string fk)

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
    public class TeamsIdImageFoldersNkPortalsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Find a related item by id for portals.
                Portal result = apiInstance.TeamsIdImageFoldersNkPortalsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalsfkput"></a>
# **TeamsIdImageFoldersNkPortalsFkPut**
> Portal TeamsIdImageFoldersNkPortalsFkPut (string id, string nk, string fk, Portal data = null)

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
    public class TeamsIdImageFoldersNkPortalsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for portals
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Update a related item by id for portals.
                Portal result = apiInstance.TeamsIdImageFoldersNkPortalsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
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

<a name="teamsidimagefoldersnkportalsget"></a>
# **TeamsIdImageFoldersNkPortalsGet**
> List<Portal> TeamsIdImageFoldersNkPortalsGet (string id, string nk, string filter = null)

Queries portals of ImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkPortalsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portals of ImageFolder.
                List&lt;Portal&gt; result = apiInstance.TeamsIdImageFoldersNkPortalsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Portal>**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalspost"></a>
# **TeamsIdImageFoldersNkPortalsPost**
> Portal TeamsIdImageFoldersNkPortalsPost (string id, string nk, Portal data = null)

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
    public class TeamsIdImageFoldersNkPortalsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Creates a new instance in portals of this model.
                Portal result = apiInstance.TeamsIdImageFoldersNkPortalsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **data** | [**Portal**](Portal.md)|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalsrelfkdelete"></a>
# **TeamsIdImageFoldersNkPortalsRelFkDelete**
> void TeamsIdImageFoldersNkPortalsRelFkDelete (string id, string nk, string fk)

Remove the portals relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkPortalsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Remove the portals relation to an item by id.
                apiInstance.TeamsIdImageFoldersNkPortalsRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalsrelfkhead"></a>
# **TeamsIdImageFoldersNkPortalsRelFkHead**
> bool? TeamsIdImageFoldersNkPortalsRelFkHead (string id, string nk, string fk)

Check the existence of portals relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkPortalsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Check the existence of portals relation to an item by id.
                bool? result = apiInstance.TeamsIdImageFoldersNkPortalsRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkportalsrelfkput"></a>
# **TeamsIdImageFoldersNkPortalsRelFkPut**
> PortalImageFolder TeamsIdImageFoldersNkPortalsRelFkPut (string id, string nk, string fk, PortalImageFolder data = null)

Add a related item by id for portals.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkPortalsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var fk = fk_example;  // string | Foreign key for portals
            var data = new PortalImageFolder(); // PortalImageFolder |  (optional) 

            try
            {
                // Add a related item by id for portals.
                PortalImageFolder result = apiInstance.TeamsIdImageFoldersNkPortalsRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkPortalsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **fk** | **string**| Foreign key for portals | 
 **data** | [**PortalImageFolder**](PortalImageFolder.md)|  | [optional] 

### Return type

[**PortalImageFolder**](PortalImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefoldersnkteamget"></a>
# **TeamsIdImageFoldersNkTeamGet**
> Team TeamsIdImageFoldersNkTeamGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImageFoldersNkTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for imageFolders.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamsIdImageFoldersNkTeamGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersNkTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for imageFolders. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagefolderspost"></a>
# **TeamsIdImageFoldersPost**
> ImageFolder TeamsIdImageFoldersPost (string id, ImageFolder data = null)

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
    public class TeamsIdImageFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Creates a new instance in imageFolders of this model.
                ImageFolder result = apiInstance.TeamsIdImageFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImageFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagescountget"></a>
# **TeamsIdImagesCountGet**
> InlineResponse200 TeamsIdImagesCountGet (string id, string where = null)

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
    public class TeamsIdImagesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts images of Team.
                InlineResponse200 result = apiInstance.TeamsIdImagesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagesdelete"></a>
# **TeamsIdImagesDelete**
> void TeamsIdImagesDelete (string id)

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
    public class TeamsIdImagesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all images of this model.
                apiInstance.TeamsIdImagesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagesfkdelete"></a>
# **TeamsIdImagesFkDelete**
> void TeamsIdImagesFkDelete (string id, string fk)

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
    public class TeamsIdImagesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for images

            try
            {
                // Delete a related item by id for images.
                apiInstance.TeamsIdImagesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for images | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagesfkget"></a>
# **TeamsIdImagesFkGet**
> Image TeamsIdImagesFkGet (string id, string fk)

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
    public class TeamsIdImagesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for images

            try
            {
                // Find a related item by id for images.
                Image result = apiInstance.TeamsIdImagesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for images | 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagesfkput"></a>
# **TeamsIdImagesFkPut**
> Image TeamsIdImagesFkPut (string id, string fk, Image data = null)

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
    public class TeamsIdImagesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for images
            var data = new Image(); // Image |  (optional) 

            try
            {
                // Update a related item by id for images.
                Image result = apiInstance.TeamsIdImagesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidimagesget"></a>
# **TeamsIdImagesGet**
> List<Image> TeamsIdImagesGet (string id, string filter = null)

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
    public class TeamsIdImagesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries images of Team.
                List&lt;Image&gt; result = apiInstance.TeamsIdImagesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Image>**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagesnkfolderget"></a>
# **TeamsIdImagesNkFolderGet**
> ImageFolder TeamsIdImagesNkFolderGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation folder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImagesNkFolderGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for images.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation folder.
                ImageFolder result = apiInstance.TeamsIdImagesNkFolderGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesNkFolderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for images. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagesnkteamget"></a>
# **TeamsIdImagesNkTeamGet**
> Team TeamsIdImagesNkTeamGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdImagesNkTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for images.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamsIdImagesNkTeamGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesNkTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for images. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidimagespost"></a>
# **TeamsIdImagesPost**
> Image TeamsIdImagesPost (string id, Image data = null)

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
    public class TeamsIdImagesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new Image(); // Image |  (optional) 

            try
            {
                // Creates a new instance in images of this model.
                Image result = apiInstance.TeamsIdImagesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdImagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**Image**](Image.md)|  | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidinvitationticketsfkdelete"></a>
# **TeamsIdInvitationTicketsFkDelete**
> Object TeamsIdInvitationTicketsFkDelete (string id, string id2, string fk)

Delete InvitationTickets for this Team

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdInvitationTicketsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var id2 = id_example;  // string | Team id
            var fk = fk_example;  // string | InvitationTicket id

            try
            {
                // Delete InvitationTickets for this Team
                Object result = apiInstance.TeamsIdInvitationTicketsFkDelete(id, id2, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdInvitationTicketsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **id2** | **string**| Team id | 
 **fk** | **string**| InvitationTicket id | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidinvitationticketsfkget"></a>
# **TeamsIdInvitationTicketsFkGet**
> InvitationTicket TeamsIdInvitationTicketsFkGet (string id, string id2, string fk, string filter = null)

Get InvitationTicket by Id for this Team

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdInvitationTicketsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var id2 = id_example;  // string | Team id
            var fk = fk_example;  // string | InvitationTicket id
            var filter = filter_example;  // string | Only include changes that match this filter (optional) 

            try
            {
                // Get InvitationTicket by Id for this Team
                InvitationTicket result = apiInstance.TeamsIdInvitationTicketsFkGet(id, id2, fk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdInvitationTicketsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **id2** | **string**| Team id | 
 **fk** | **string**| InvitationTicket id | 
 **filter** | **string**| Only include changes that match this filter | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidinvitationticketsget"></a>
# **TeamsIdInvitationTicketsGet**
> List<InvitationTicket> TeamsIdInvitationTicketsGet (string id, string id2, string filter = null)

List InvitationTickets for this Team

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdInvitationTicketsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var id2 = id_example;  // string | Team id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // List InvitationTickets for this Team
                List&lt;InvitationTicket&gt; result = apiInstance.TeamsIdInvitationTicketsGet(id, id2, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdInvitationTicketsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **id2** | **string**| Team id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<InvitationTicket>**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidlogoput"></a>
# **TeamsIdLogoPut**
> Team TeamsIdLogoPut (string id, string id2, Team data)

Change logo

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdLogoPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var id2 = id_example;  // string | Team id
            var data = new Team(); // Team | Logo

            try
            {
                // Change logo
                Team result = apiInstance.TeamsIdLogoPut(id, id2, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdLogoPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **id2** | **string**| Team id | 
 **data** | [**Team**](Team.md)| Logo | 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmemberscountget"></a>
# **TeamsIdMembersCountGet**
> InlineResponse200 TeamsIdMembersCountGet (string id, string where = null)

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
    public class TeamsIdMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts members of Team.
                InlineResponse200 result = apiInstance.TeamsIdMembersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmembersdelete"></a>
# **TeamsIdMembersDelete**
> void TeamsIdMembersDelete (string id)

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
    public class TeamsIdMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all members of this model.
                apiInstance.TeamsIdMembersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmembersfkdelete"></a>
# **TeamsIdMembersFkDelete**
> void TeamsIdMembersFkDelete (string id, string fk)

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
    public class TeamsIdMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Delete a related item by id for members.
                apiInstance.TeamsIdMembersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmembersfkget"></a>
# **TeamsIdMembersFkGet**
> Customer TeamsIdMembersFkGet (string id, string fk)

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
    public class TeamsIdMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Find a related item by id for members.
                Customer result = apiInstance.TeamsIdMembersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for members | 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmembersfkput"></a>
# **TeamsIdMembersFkPut**
> Customer TeamsIdMembersFkPut (string id, string fk, Customer data = null)

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
    public class TeamsIdMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for members
            var data = new Customer(); // Customer |  (optional) 

            try
            {
                // Update a related item by id for members.
                Customer result = apiInstance.TeamsIdMembersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidmembersget"></a>
# **TeamsIdMembersGet**
> List<Customer> TeamsIdMembersGet (string id, string filter = null)

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
    public class TeamsIdMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries members of Team.
                List&lt;Customer&gt; result = apiInstance.TeamsIdMembersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Customer>**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmemberspost"></a>
# **TeamsIdMembersPost**
> Customer TeamsIdMembersPost (string id, Customer data = null)

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
    public class TeamsIdMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new Customer(); // Customer |  (optional) 

            try
            {
                // Creates a new instance in members of this model.
                Customer result = apiInstance.TeamsIdMembersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**Customer**](Customer.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmembersrelfkdelete"></a>
# **TeamsIdMembersRelFkDelete**
> void TeamsIdMembersRelFkDelete (string id, string fk)

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
    public class TeamsIdMembersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Remove the members relation to an item by id.
                apiInstance.TeamsIdMembersRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmembersrelfkhead"></a>
# **TeamsIdMembersRelFkHead**
> bool? TeamsIdMembersRelFkHead (string id, string fk)

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
    public class TeamsIdMembersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Check the existence of members relation to an item by id.
                bool? result = apiInstance.TeamsIdMembersRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for members | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidmembersrelfkput"></a>
# **TeamsIdMembersRelFkPut**
> TeamMember TeamsIdMembersRelFkPut (string id, string fk, TeamMember data = null)

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
    public class TeamsIdMembersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for members
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Add a related item by id for members.
                TeamMember result = apiInstance.TeamsIdMembersRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdMembersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidpatch"></a>
# **TeamsIdPatch**
> Team TeamsIdPatch (string id, Team data = null)

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
    public class TeamsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new Team(); // Team | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                Team result = apiInstance.TeamsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**Team**](Team.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidpermissiondelete"></a>
# **TeamsIdPermissionDelete**
> void TeamsIdPermissionDelete (string id)

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
    public class TeamsIdPermissionDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes permission of this model.
                apiInstance.TeamsIdPermissionDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPermissionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidpermissionget"></a>
# **TeamsIdPermissionGet**
> TeamPermissionSet TeamsIdPermissionGet (string id, bool? refresh = null)

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
    public class TeamsIdPermissionGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation permission.
                TeamPermissionSet result = apiInstance.TeamsIdPermissionGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPermissionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidpermissionpost"></a>
# **TeamsIdPermissionPost**
> TeamPermissionSet TeamsIdPermissionPost (string id, TeamPermissionSet data = null)

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
    public class TeamsIdPermissionPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new TeamPermissionSet(); // TeamPermissionSet |  (optional) 

            try
            {
                // Creates a new instance in permission of this model.
                TeamPermissionSet result = apiInstance.TeamsIdPermissionPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPermissionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidpermissionput"></a>
# **TeamsIdPermissionPut**
> TeamPermissionSet TeamsIdPermissionPut (string id, TeamPermissionSet data = null)

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
    public class TeamsIdPermissionPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new TeamPermissionSet(); // TeamPermissionSet |  (optional) 

            try
            {
                // Update permission of this model.
                TeamPermissionSet result = apiInstance.TeamsIdPermissionPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPermissionPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalscountget"></a>
# **TeamsIdPortalsCountGet**
> InlineResponse200 TeamsIdPortalsCountGet (string id, string where = null)

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
    public class TeamsIdPortalsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portals of Team.
                InlineResponse200 result = apiInstance.TeamsIdPortalsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsdelete"></a>
# **TeamsIdPortalsDelete**
> void TeamsIdPortalsDelete (string id)

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
    public class TeamsIdPortalsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all portals of this model.
                apiInstance.TeamsIdPortalsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsfkdelete"></a>
# **TeamsIdPortalsFkDelete**
> void TeamsIdPortalsFkDelete (string id, string fk)

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
    public class TeamsIdPortalsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Delete a related item by id for portals.
                apiInstance.TeamsIdPortalsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsfkget"></a>
# **TeamsIdPortalsFkGet**
> Portal TeamsIdPortalsFkGet (string id, string fk)

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
    public class TeamsIdPortalsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Find a related item by id for portals.
                Portal result = apiInstance.TeamsIdPortalsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for portals | 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsfkput"></a>
# **TeamsIdPortalsFkPut**
> Portal TeamsIdPortalsFkPut (string id, string fk, Portal data = null)

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
    public class TeamsIdPortalsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for portals
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Update a related item by id for portals.
                Portal result = apiInstance.TeamsIdPortalsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidportalsget"></a>
# **TeamsIdPortalsGet**
> List<Portal> TeamsIdPortalsGet (string id, string filter = null)

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
    public class TeamsIdPortalsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portals of Team.
                List&lt;Portal&gt; result = apiInstance.TeamsIdPortalsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Portal>**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignfolderscountget"></a>
# **TeamsIdPortalsNkDesignFoldersCountGet**
> InlineResponse200 TeamsIdPortalsNkDesignFoldersCountGet (string id, string nk, string where = null)

Counts designFolders of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designFolders of Portal.
                InlineResponse200 result = apiInstance.TeamsIdPortalsNkDesignFoldersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignfoldersdelete"></a>
# **TeamsIdPortalsNkDesignFoldersDelete**
> void TeamsIdPortalsNkDesignFoldersDelete (string id, string nk)

Deletes all designFolders of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes all designFolders of this model.
                apiInstance.TeamsIdPortalsNkDesignFoldersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignfoldersfkdelete"></a>
# **TeamsIdPortalsNkDesignFoldersFkDelete**
> void TeamsIdPortalsNkDesignFoldersFkDelete (string id, string nk, string fk)

Delete a related item by id for designFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for designFolders

            try
            {
                // Delete a related item by id for designFolders.
                apiInstance.TeamsIdPortalsNkDesignFoldersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for designFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignfoldersfkget"></a>
# **TeamsIdPortalsNkDesignFoldersFkGet**
> DesignFolder TeamsIdPortalsNkDesignFoldersFkGet (string id, string nk, string fk)

Find a related item by id for designFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for designFolders

            try
            {
                // Find a related item by id for designFolders.
                DesignFolder result = apiInstance.TeamsIdPortalsNkDesignFoldersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for designFolders | 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignfoldersfkput"></a>
# **TeamsIdPortalsNkDesignFoldersFkPut**
> DesignFolder TeamsIdPortalsNkDesignFoldersFkPut (string id, string nk, string fk, DesignFolder data = null)

Update a related item by id for designFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for designFolders
            var data = new DesignFolder(); // DesignFolder |  (optional) 

            try
            {
                // Update a related item by id for designFolders.
                DesignFolder result = apiInstance.TeamsIdPortalsNkDesignFoldersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for designFolders | 
 **data** | [**DesignFolder**](DesignFolder.md)|  | [optional] 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignfoldersget"></a>
# **TeamsIdPortalsNkDesignFoldersGet**
> List<DesignFolder> TeamsIdPortalsNkDesignFoldersGet (string id, string nk, string filter = null)

Queries designFolders of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designFolders of Portal.
                List&lt;DesignFolder&gt; result = apiInstance.TeamsIdPortalsNkDesignFoldersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignFolder>**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignfolderspost"></a>
# **TeamsIdPortalsNkDesignFoldersPost**
> DesignFolder TeamsIdPortalsNkDesignFoldersPost (string id, string nk, DesignFolder data = null)

Creates a new instance in designFolders of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new DesignFolder(); // DesignFolder |  (optional) 

            try
            {
                // Creates a new instance in designFolders of this model.
                DesignFolder result = apiInstance.TeamsIdPortalsNkDesignFoldersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**DesignFolder**](DesignFolder.md)|  | [optional] 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignscountget"></a>
# **TeamsIdPortalsNkDesignsCountGet**
> InlineResponse200 TeamsIdPortalsNkDesignsCountGet (string id, string nk, string where = null)

Counts designs of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designs of Portal.
                InlineResponse200 result = apiInstance.TeamsIdPortalsNkDesignsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignsdelete"></a>
# **TeamsIdPortalsNkDesignsDelete**
> void TeamsIdPortalsNkDesignsDelete (string id, string nk)

Deletes all designs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes all designs of this model.
                apiInstance.TeamsIdPortalsNkDesignsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignsfkdelete"></a>
# **TeamsIdPortalsNkDesignsFkDelete**
> void TeamsIdPortalsNkDesignsFkDelete (string id, string nk, string fk)

Delete a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Delete a related item by id for designs.
                apiInstance.TeamsIdPortalsNkDesignsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for designs | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignsfkget"></a>
# **TeamsIdPortalsNkDesignsFkGet**
> Design TeamsIdPortalsNkDesignsFkGet (string id, string nk, string fk)

Find a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Find a related item by id for designs.
                Design result = apiInstance.TeamsIdPortalsNkDesignsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for designs | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignsfkput"></a>
# **TeamsIdPortalsNkDesignsFkPut**
> Design TeamsIdPortalsNkDesignsFkPut (string id, string nk, string fk, Design data = null)

Update a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for designs
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for designs.
                Design result = apiInstance.TeamsIdPortalsNkDesignsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for designs | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignsget"></a>
# **TeamsIdPortalsNkDesignsGet**
> List<Design> TeamsIdPortalsNkDesignsGet (string id, string nk, string filter = null)

Queries designs of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designs of Portal.
                List&lt;Design&gt; result = apiInstance.TeamsIdPortalsNkDesignsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkdesignspost"></a>
# **TeamsIdPortalsNkDesignsPost**
> Design TeamsIdPortalsNkDesignsPost (string id, string nk, Design data = null)

Creates a new instance in designs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in designs of this model.
                Design result = apiInstance.TeamsIdPortalsNkDesignsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefolderscountget"></a>
# **TeamsIdPortalsNkImageFoldersCountGet**
> InlineResponse200 TeamsIdPortalsNkImageFoldersCountGet (string id, string nk, string where = null)

Counts imageFolders of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkImageFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts imageFolders of Portal.
                InlineResponse200 result = apiInstance.TeamsIdPortalsNkImageFoldersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefoldersdelete"></a>
# **TeamsIdPortalsNkImageFoldersDelete**
> void TeamsIdPortalsNkImageFoldersDelete (string id, string nk)

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
    public class TeamsIdPortalsNkImageFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes all imageFolders of this model.
                apiInstance.TeamsIdPortalsNkImageFoldersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefoldersfkdelete"></a>
# **TeamsIdPortalsNkImageFoldersFkDelete**
> void TeamsIdPortalsNkImageFoldersFkDelete (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkImageFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Delete a related item by id for imageFolders.
                apiInstance.TeamsIdPortalsNkImageFoldersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefoldersfkget"></a>
# **TeamsIdPortalsNkImageFoldersFkGet**
> ImageFolder TeamsIdPortalsNkImageFoldersFkGet (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkImageFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Find a related item by id for imageFolders.
                ImageFolder result = apiInstance.TeamsIdPortalsNkImageFoldersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefoldersfkput"></a>
# **TeamsIdPortalsNkImageFoldersFkPut**
> ImageFolder TeamsIdPortalsNkImageFoldersFkPut (string id, string nk, string fk, ImageFolder data = null)

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
    public class TeamsIdPortalsNkImageFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Update a related item by id for imageFolders.
                ImageFolder result = apiInstance.TeamsIdPortalsNkImageFoldersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
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

<a name="teamsidportalsnkimagefoldersget"></a>
# **TeamsIdPortalsNkImageFoldersGet**
> List<ImageFolder> TeamsIdPortalsNkImageFoldersGet (string id, string nk, string filter = null)

Queries imageFolders of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkImageFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries imageFolders of Portal.
                List&lt;ImageFolder&gt; result = apiInstance.TeamsIdPortalsNkImageFoldersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ImageFolder>**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefolderspost"></a>
# **TeamsIdPortalsNkImageFoldersPost**
> ImageFolder TeamsIdPortalsNkImageFoldersPost (string id, string nk, ImageFolder data = null)

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
    public class TeamsIdPortalsNkImageFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Creates a new instance in imageFolders of this model.
                ImageFolder result = apiInstance.TeamsIdPortalsNkImageFoldersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefoldersrelfkdelete"></a>
# **TeamsIdPortalsNkImageFoldersRelFkDelete**
> void TeamsIdPortalsNkImageFoldersRelFkDelete (string id, string nk, string fk)

Remove the imageFolders relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkImageFoldersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Remove the imageFolders relation to an item by id.
                apiInstance.TeamsIdPortalsNkImageFoldersRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefoldersrelfkhead"></a>
# **TeamsIdPortalsNkImageFoldersRelFkHead**
> bool? TeamsIdPortalsNkImageFoldersRelFkHead (string id, string nk, string fk)

Check the existence of imageFolders relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkImageFoldersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Check the existence of imageFolders relation to an item by id.
                bool? result = apiInstance.TeamsIdPortalsNkImageFoldersRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkimagefoldersrelfkput"></a>
# **TeamsIdPortalsNkImageFoldersRelFkPut**
> PortalImageFolder TeamsIdPortalsNkImageFoldersRelFkPut (string id, string nk, string fk, PortalImageFolder data = null)

Add a related item by id for imageFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkImageFoldersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new PortalImageFolder(); // PortalImageFolder |  (optional) 

            try
            {
                // Add a related item by id for imageFolders.
                PortalImageFolder result = apiInstance.TeamsIdPortalsNkImageFoldersRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkImageFoldersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for imageFolders | 
 **data** | [**PortalImageFolder**](PortalImageFolder.md)|  | [optional] 

### Return type

[**PortalImageFolder**](PortalImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmemberscountget"></a>
# **TeamsIdPortalsNkMembersCountGet**
> InlineResponse200 TeamsIdPortalsNkMembersCountGet (string id, string nk, string where = null)

Counts members of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts members of Portal.
                InlineResponse200 result = apiInstance.TeamsIdPortalsNkMembersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmembersdelete"></a>
# **TeamsIdPortalsNkMembersDelete**
> void TeamsIdPortalsNkMembersDelete (string id, string nk)

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
    public class TeamsIdPortalsNkMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes all members of this model.
                apiInstance.TeamsIdPortalsNkMembersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmembersfkdelete"></a>
# **TeamsIdPortalsNkMembersFkDelete**
> void TeamsIdPortalsNkMembersFkDelete (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Delete a related item by id for members.
                apiInstance.TeamsIdPortalsNkMembersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmembersfkget"></a>
# **TeamsIdPortalsNkMembersFkGet**
> TeamMember TeamsIdPortalsNkMembersFkGet (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Find a related item by id for members.
                TeamMember result = apiInstance.TeamsIdPortalsNkMembersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for members | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmembersfkput"></a>
# **TeamsIdPortalsNkMembersFkPut**
> TeamMember TeamsIdPortalsNkMembersFkPut (string id, string nk, string fk, TeamMember data = null)

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
    public class TeamsIdPortalsNkMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for members
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for members.
                TeamMember result = apiInstance.TeamsIdPortalsNkMembersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
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

<a name="teamsidportalsnkmembersget"></a>
# **TeamsIdPortalsNkMembersGet**
> List<TeamMember> TeamsIdPortalsNkMembersGet (string id, string nk, string filter = null)

Queries members of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries members of Portal.
                List&lt;TeamMember&gt; result = apiInstance.TeamsIdPortalsNkMembersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmemberspost"></a>
# **TeamsIdPortalsNkMembersPost**
> TeamMember TeamsIdPortalsNkMembersPost (string id, string nk, TeamMember data = null)

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
    public class TeamsIdPortalsNkMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in members of this model.
                TeamMember result = apiInstance.TeamsIdPortalsNkMembersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmembersrelfkdelete"></a>
# **TeamsIdPortalsNkMembersRelFkDelete**
> void TeamsIdPortalsNkMembersRelFkDelete (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkMembersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Remove the members relation to an item by id.
                apiInstance.TeamsIdPortalsNkMembersRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmembersrelfkhead"></a>
# **TeamsIdPortalsNkMembersRelFkHead**
> bool? TeamsIdPortalsNkMembersRelFkHead (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkMembersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Check the existence of members relation to an item by id.
                bool? result = apiInstance.TeamsIdPortalsNkMembersRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for members | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkmembersrelfkput"></a>
# **TeamsIdPortalsNkMembersRelFkPut**
> PortalMember TeamsIdPortalsNkMembersRelFkPut (string id, string nk, string fk, PortalMember data = null)

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
    public class TeamsIdPortalsNkMembersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for members
            var data = new PortalMember(); // PortalMember |  (optional) 

            try
            {
                // Add a related item by id for members.
                PortalMember result = apiInstance.TeamsIdPortalsNkMembersRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkMembersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for members | 
 **data** | [**PortalMember**](PortalMember.md)|  | [optional] 

### Return type

[**PortalMember**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkpermissiondelete"></a>
# **TeamsIdPortalsNkPermissionDelete**
> void TeamsIdPortalsNkPermissionDelete (string id, string nk)

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
    public class TeamsIdPortalsNkPermissionDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes permission of this model.
                apiInstance.TeamsIdPortalsNkPermissionDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPermissionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkpermissionget"></a>
# **TeamsIdPortalsNkPermissionGet**
> PortalPermissionSet TeamsIdPortalsNkPermissionGet (string id, string nk, bool? refresh = null)

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
    public class TeamsIdPortalsNkPermissionGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation permission.
                PortalPermissionSet result = apiInstance.TeamsIdPortalsNkPermissionGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPermissionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**PortalPermissionSet**](PortalPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkpermissionpost"></a>
# **TeamsIdPortalsNkPermissionPost**
> PortalPermissionSet TeamsIdPortalsNkPermissionPost (string id, string nk, PortalPermissionSet data = null)

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
    public class TeamsIdPortalsNkPermissionPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new PortalPermissionSet(); // PortalPermissionSet |  (optional) 

            try
            {
                // Creates a new instance in permission of this model.
                PortalPermissionSet result = apiInstance.TeamsIdPortalsNkPermissionPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPermissionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**PortalPermissionSet**](PortalPermissionSet.md)|  | [optional] 

### Return type

[**PortalPermissionSet**](PortalPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkpermissionput"></a>
# **TeamsIdPortalsNkPermissionPut**
> PortalPermissionSet TeamsIdPortalsNkPermissionPut (string id, string nk, PortalPermissionSet data = null)

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
    public class TeamsIdPortalsNkPermissionPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new PortalPermissionSet(); // PortalPermissionSet |  (optional) 

            try
            {
                // Update permission of this model.
                PortalPermissionSet result = apiInstance.TeamsIdPortalsNkPermissionPut(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPermissionPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**PortalPermissionSet**](PortalPermissionSet.md)|  | [optional] 

### Return type

[**PortalPermissionSet**](PortalPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkportalmemberscountget"></a>
# **TeamsIdPortalsNkPortalMembersCountGet**
> InlineResponse200 TeamsIdPortalsNkPortalMembersCountGet (string id, string nk, string where = null)

Counts portalMembers of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkPortalMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portalMembers of Portal.
                InlineResponse200 result = apiInstance.TeamsIdPortalsNkPortalMembersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPortalMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkportalmembersdelete"></a>
# **TeamsIdPortalsNkPortalMembersDelete**
> void TeamsIdPortalsNkPortalMembersDelete (string id, string nk)

Deletes all portalMembers of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkPortalMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes all portalMembers of this model.
                apiInstance.TeamsIdPortalsNkPortalMembersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPortalMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkportalmembersfkdelete"></a>
# **TeamsIdPortalsNkPortalMembersFkDelete**
> void TeamsIdPortalsNkPortalMembersFkDelete (string id, string nk, string fk)

Delete a related item by id for portalMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkPortalMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for portalMembers

            try
            {
                // Delete a related item by id for portalMembers.
                apiInstance.TeamsIdPortalsNkPortalMembersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPortalMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for portalMembers | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkportalmembersfkget"></a>
# **TeamsIdPortalsNkPortalMembersFkGet**
> PortalMember TeamsIdPortalsNkPortalMembersFkGet (string id, string nk, string fk)

Find a related item by id for portalMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkPortalMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for portalMembers

            try
            {
                // Find a related item by id for portalMembers.
                PortalMember result = apiInstance.TeamsIdPortalsNkPortalMembersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPortalMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for portalMembers | 

### Return type

[**PortalMember**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkportalmembersfkput"></a>
# **TeamsIdPortalsNkPortalMembersFkPut**
> PortalMember TeamsIdPortalsNkPortalMembersFkPut (string id, string nk, string fk, PortalMember data = null)

Update a related item by id for portalMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkPortalMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for portalMembers
            var data = new PortalMember(); // PortalMember |  (optional) 

            try
            {
                // Update a related item by id for portalMembers.
                PortalMember result = apiInstance.TeamsIdPortalsNkPortalMembersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPortalMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for portalMembers | 
 **data** | [**PortalMember**](PortalMember.md)|  | [optional] 

### Return type

[**PortalMember**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkportalmembersget"></a>
# **TeamsIdPortalsNkPortalMembersGet**
> List<PortalMember> TeamsIdPortalsNkPortalMembersGet (string id, string nk, string filter = null)

Queries portalMembers of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkPortalMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portalMembers of Portal.
                List&lt;PortalMember&gt; result = apiInstance.TeamsIdPortalsNkPortalMembersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPortalMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<PortalMember>**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkportalmemberspost"></a>
# **TeamsIdPortalsNkPortalMembersPost**
> PortalMember TeamsIdPortalsNkPortalMembersPost (string id, string nk, PortalMember data = null)

Creates a new instance in portalMembers of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkPortalMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new PortalMember(); // PortalMember |  (optional) 

            try
            {
                // Creates a new instance in portalMembers of this model.
                PortalMember result = apiInstance.TeamsIdPortalsNkPortalMembersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkPortalMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**PortalMember**](PortalMember.md)|  | [optional] 

### Return type

[**PortalMember**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnkteamget"></a>
# **TeamsIdPortalsNkTeamGet**
> Team TeamsIdPortalsNkTeamGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamsIdPortalsNkTeamGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatefolderscountget"></a>
# **TeamsIdPortalsNkTemplateFoldersCountGet**
> InlineResponse200 TeamsIdPortalsNkTemplateFoldersCountGet (string id, string nk, string where = null)

Counts templateFolders of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templateFolders of Portal.
                InlineResponse200 result = apiInstance.TeamsIdPortalsNkTemplateFoldersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatefoldersdelete"></a>
# **TeamsIdPortalsNkTemplateFoldersDelete**
> void TeamsIdPortalsNkTemplateFoldersDelete (string id, string nk)

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
    public class TeamsIdPortalsNkTemplateFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes all templateFolders of this model.
                apiInstance.TeamsIdPortalsNkTemplateFoldersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatefoldersfkdelete"></a>
# **TeamsIdPortalsNkTemplateFoldersFkDelete**
> void TeamsIdPortalsNkTemplateFoldersFkDelete (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkTemplateFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Delete a related item by id for templateFolders.
                apiInstance.TeamsIdPortalsNkTemplateFoldersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatefoldersfkget"></a>
# **TeamsIdPortalsNkTemplateFoldersFkGet**
> PortalTemplateFolder TeamsIdPortalsNkTemplateFoldersFkGet (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkTemplateFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Find a related item by id for templateFolders.
                PortalTemplateFolder result = apiInstance.TeamsIdPortalsNkTemplateFoldersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatefoldersfkput"></a>
# **TeamsIdPortalsNkTemplateFoldersFkPut**
> PortalTemplateFolder TeamsIdPortalsNkTemplateFoldersFkPut (string id, string nk, string fk, PortalTemplateFolder data = null)

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
    public class TeamsIdPortalsNkTemplateFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templateFolders
            var data = new PortalTemplateFolder(); // PortalTemplateFolder |  (optional) 

            try
            {
                // Update a related item by id for templateFolders.
                PortalTemplateFolder result = apiInstance.TeamsIdPortalsNkTemplateFoldersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templateFolders | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)|  | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatefoldersget"></a>
# **TeamsIdPortalsNkTemplateFoldersGet**
> List<PortalTemplateFolder> TeamsIdPortalsNkTemplateFoldersGet (string id, string nk, string filter = null)

Queries templateFolders of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templateFolders of Portal.
                List&lt;PortalTemplateFolder&gt; result = apiInstance.TeamsIdPortalsNkTemplateFoldersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<PortalTemplateFolder>**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatefolderspost"></a>
# **TeamsIdPortalsNkTemplateFoldersPost**
> PortalTemplateFolder TeamsIdPortalsNkTemplateFoldersPost (string id, string nk, PortalTemplateFolder data = null)

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
    public class TeamsIdPortalsNkTemplateFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new PortalTemplateFolder(); // PortalTemplateFolder |  (optional) 

            try
            {
                // Creates a new instance in templateFolders of this model.
                PortalTemplateFolder result = apiInstance.TeamsIdPortalsNkTemplateFoldersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)|  | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplaterelscountget"></a>
# **TeamsIdPortalsNkTemplateRelsCountGet**
> InlineResponse200 TeamsIdPortalsNkTemplateRelsCountGet (string id, string nk, string where = null)

Counts templateRels of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateRelsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templateRels of Portal.
                InlineResponse200 result = apiInstance.TeamsIdPortalsNkTemplateRelsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateRelsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplaterelsdelete"></a>
# **TeamsIdPortalsNkTemplateRelsDelete**
> void TeamsIdPortalsNkTemplateRelsDelete (string id, string nk)

Deletes all templateRels of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateRelsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes all templateRels of this model.
                apiInstance.TeamsIdPortalsNkTemplateRelsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateRelsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplaterelsfkdelete"></a>
# **TeamsIdPortalsNkTemplateRelsFkDelete**
> void TeamsIdPortalsNkTemplateRelsFkDelete (string id, string nk, string fk)

Delete a related item by id for templateRels.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateRelsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templateRels

            try
            {
                // Delete a related item by id for templateRels.
                apiInstance.TeamsIdPortalsNkTemplateRelsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateRelsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templateRels | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplaterelsfkget"></a>
# **TeamsIdPortalsNkTemplateRelsFkGet**
> PortalTemplate TeamsIdPortalsNkTemplateRelsFkGet (string id, string nk, string fk)

Find a related item by id for templateRels.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateRelsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templateRels

            try
            {
                // Find a related item by id for templateRels.
                PortalTemplate result = apiInstance.TeamsIdPortalsNkTemplateRelsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateRelsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templateRels | 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplaterelsfkput"></a>
# **TeamsIdPortalsNkTemplateRelsFkPut**
> PortalTemplate TeamsIdPortalsNkTemplateRelsFkPut (string id, string nk, string fk, PortalTemplate data = null)

Update a related item by id for templateRels.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateRelsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templateRels
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Update a related item by id for templateRels.
                PortalTemplate result = apiInstance.TeamsIdPortalsNkTemplateRelsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateRelsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templateRels | 
 **data** | [**PortalTemplate**](PortalTemplate.md)|  | [optional] 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplaterelsget"></a>
# **TeamsIdPortalsNkTemplateRelsGet**
> List<PortalTemplate> TeamsIdPortalsNkTemplateRelsGet (string id, string nk, string filter = null)

Queries templateRels of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateRelsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templateRels of Portal.
                List&lt;PortalTemplate&gt; result = apiInstance.TeamsIdPortalsNkTemplateRelsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateRelsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<PortalTemplate>**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplaterelspost"></a>
# **TeamsIdPortalsNkTemplateRelsPost**
> PortalTemplate TeamsIdPortalsNkTemplateRelsPost (string id, string nk, PortalTemplate data = null)

Creates a new instance in templateRels of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplateRelsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Creates a new instance in templateRels of this model.
                PortalTemplate result = apiInstance.TeamsIdPortalsNkTemplateRelsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplateRelsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**PortalTemplate**](PortalTemplate.md)|  | [optional] 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatescountget"></a>
# **TeamsIdPortalsNkTemplatesCountGet**
> InlineResponse200 TeamsIdPortalsNkTemplatesCountGet (string id, string nk, string where = null)

Counts templates of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of Portal.
                InlineResponse200 result = apiInstance.TeamsIdPortalsNkTemplatesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatesdelete"></a>
# **TeamsIdPortalsNkTemplatesDelete**
> void TeamsIdPortalsNkTemplatesDelete (string id, string nk)

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
    public class TeamsIdPortalsNkTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.

            try
            {
                // Deletes all templates of this model.
                apiInstance.TeamsIdPortalsNkTemplatesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatesfkdelete"></a>
# **TeamsIdPortalsNkTemplatesFkDelete**
> void TeamsIdPortalsNkTemplatesFkDelete (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.TeamsIdPortalsNkTemplatesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatesfkget"></a>
# **TeamsIdPortalsNkTemplatesFkGet**
> Template TeamsIdPortalsNkTemplatesFkGet (string id, string nk, string fk)

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
    public class TeamsIdPortalsNkTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.TeamsIdPortalsNkTemplatesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatesfkput"></a>
# **TeamsIdPortalsNkTemplatesFkPut**
> Template TeamsIdPortalsNkTemplatesFkPut (string id, string nk, string fk, Template data = null)

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
    public class TeamsIdPortalsNkTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.TeamsIdPortalsNkTemplatesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
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

<a name="teamsidportalsnktemplatesget"></a>
# **TeamsIdPortalsNkTemplatesGet**
> List<Template> TeamsIdPortalsNkTemplatesGet (string id, string nk, string filter = null)

Queries templates of Portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of Portal.
                List&lt;Template&gt; result = apiInstance.TeamsIdPortalsNkTemplatesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatespost"></a>
# **TeamsIdPortalsNkTemplatesPost**
> Template TeamsIdPortalsNkTemplatesPost (string id, string nk, Template data = null)

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
    public class TeamsIdPortalsNkTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.TeamsIdPortalsNkTemplatesPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatesrelfkdelete"></a>
# **TeamsIdPortalsNkTemplatesRelFkDelete**
> void TeamsIdPortalsNkTemplatesRelFkDelete (string id, string nk, string fk)

Remove the templates relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplatesRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Remove the templates relation to an item by id.
                apiInstance.TeamsIdPortalsNkTemplatesRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatesrelfkhead"></a>
# **TeamsIdPortalsNkTemplatesRelFkHead**
> bool? TeamsIdPortalsNkTemplatesRelFkHead (string id, string nk, string fk)

Check the existence of templates relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplatesRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Check the existence of templates relation to an item by id.
                bool? result = apiInstance.TeamsIdPortalsNkTemplatesRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templates | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalsnktemplatesrelfkput"></a>
# **TeamsIdPortalsNkTemplatesRelFkPut**
> PortalTemplate TeamsIdPortalsNkTemplatesRelFkPut (string id, string nk, string fk, PortalTemplate data = null)

Add a related item by id for templates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdPortalsNkTemplatesRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for portals.
            var fk = fk_example;  // string | Foreign key for templates
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Add a related item by id for templates.
                PortalTemplate result = apiInstance.TeamsIdPortalsNkTemplatesRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsNkTemplatesRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for portals. | 
 **fk** | **string**| Foreign key for templates | 
 **data** | [**PortalTemplate**](PortalTemplate.md)|  | [optional] 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidportalspost"></a>
# **TeamsIdPortalsPost**
> Portal TeamsIdPortalsPost (string id, Portal data = null)

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
    public class TeamsIdPortalsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Creates a new instance in portals of this model.
                Portal result = apiInstance.TeamsIdPortalsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPortalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**Portal**](Portal.md)|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidput"></a>
# **TeamsIdPut**
> Team TeamsIdPut (string id, Team data = null)

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
    public class TeamsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Model id
            var data = new Team(); // Team | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Team result = apiInstance.TeamsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Team**](Team.md)| Model instance data | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidreplacepost"></a>
# **TeamsIdReplacePost**
> Team TeamsIdReplacePost (string id, Team data = null)

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
    public class TeamsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Model id
            var data = new Team(); // Team | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Team result = apiInstance.TeamsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Team**](Team.md)| Model instance data | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidteammemberscountget"></a>
# **TeamsIdTeamMembersCountGet**
> InlineResponse200 TeamsIdTeamMembersCountGet (string id, string where = null)

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
    public class TeamsIdTeamMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts teamMembers of Team.
                InlineResponse200 result = apiInstance.TeamsIdTeamMembersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTeamMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidteammembersdelete"></a>
# **TeamsIdTeamMembersDelete**
> void TeamsIdTeamMembersDelete (string id)

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
    public class TeamsIdTeamMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all teamMembers of this model.
                apiInstance.TeamsIdTeamMembersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTeamMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidteammembersfkdelete"></a>
# **TeamsIdTeamMembersFkDelete**
> void TeamsIdTeamMembersFkDelete (string id, string fk)

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
    public class TeamsIdTeamMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for teamMembers

            try
            {
                // Delete a related item by id for teamMembers.
                apiInstance.TeamsIdTeamMembersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTeamMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for teamMembers | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidteammembersfkget"></a>
# **TeamsIdTeamMembersFkGet**
> TeamMember TeamsIdTeamMembersFkGet (string id, string fk)

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
    public class TeamsIdTeamMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for teamMembers

            try
            {
                // Find a related item by id for teamMembers.
                TeamMember result = apiInstance.TeamsIdTeamMembersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTeamMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for teamMembers | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidteammembersfkput"></a>
# **TeamsIdTeamMembersFkPut**
> TeamMember TeamsIdTeamMembersFkPut (string id, string fk, TeamMember data = null)

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
    public class TeamsIdTeamMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for teamMembers
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for teamMembers.
                TeamMember result = apiInstance.TeamsIdTeamMembersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTeamMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidteammembersget"></a>
# **TeamsIdTeamMembersGet**
> List<TeamMember> TeamsIdTeamMembersGet (string id, string filter = null)

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
    public class TeamsIdTeamMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries teamMembers of Team.
                List&lt;TeamMember&gt; result = apiInstance.TeamsIdTeamMembersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTeamMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidteammemberspost"></a>
# **TeamsIdTeamMembersPost**
> TeamMember TeamsIdTeamMembersPost (string id, TeamMember data = null)

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
    public class TeamsIdTeamMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in teamMembers of this model.
                TeamMember result = apiInstance.TeamsIdTeamMembersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTeamMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatefolderscountget"></a>
# **TeamsIdTemplateFoldersCountGet**
> InlineResponse200 TeamsIdTemplateFoldersCountGet (string id, string where = null)

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
    public class TeamsIdTemplateFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templateFolders of Team.
                InlineResponse200 result = apiInstance.TeamsIdTemplateFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplateFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatefoldersdelete"></a>
# **TeamsIdTemplateFoldersDelete**
> void TeamsIdTemplateFoldersDelete (string id)

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
    public class TeamsIdTemplateFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all templateFolders of this model.
                apiInstance.TeamsIdTemplateFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplateFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatefoldersfkdelete"></a>
# **TeamsIdTemplateFoldersFkDelete**
> void TeamsIdTemplateFoldersFkDelete (string id, string fk)

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
    public class TeamsIdTemplateFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Delete a related item by id for templateFolders.
                apiInstance.TeamsIdTemplateFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplateFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatefoldersfkget"></a>
# **TeamsIdTemplateFoldersFkGet**
> TeamTemplateFolder TeamsIdTemplateFoldersFkGet (string id, string fk)

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
    public class TeamsIdTemplateFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Find a related item by id for templateFolders.
                TeamTemplateFolder result = apiInstance.TeamsIdTemplateFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplateFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatefoldersfkput"></a>
# **TeamsIdTemplateFoldersFkPut**
> TeamTemplateFolder TeamsIdTemplateFoldersFkPut (string id, string fk, TeamTemplateFolder data = null)

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
    public class TeamsIdTemplateFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for templateFolders
            var data = new TeamTemplateFolder(); // TeamTemplateFolder |  (optional) 

            try
            {
                // Update a related item by id for templateFolders.
                TeamTemplateFolder result = apiInstance.TeamsIdTemplateFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplateFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidtemplatefoldersget"></a>
# **TeamsIdTemplateFoldersGet**
> List<TeamTemplateFolder> TeamsIdTemplateFoldersGet (string id, string filter = null)

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
    public class TeamsIdTemplateFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templateFolders of Team.
                List&lt;TeamTemplateFolder&gt; result = apiInstance.TeamsIdTemplateFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplateFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamTemplateFolder>**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatefolderspost"></a>
# **TeamsIdTemplateFoldersPost**
> TeamTemplateFolder TeamsIdTemplateFoldersPost (string id, TeamTemplateFolder data = null)

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
    public class TeamsIdTemplateFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new TeamTemplateFolder(); // TeamTemplateFolder |  (optional) 

            try
            {
                // Creates a new instance in templateFolders of this model.
                TeamTemplateFolder result = apiInstance.TeamsIdTemplateFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplateFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)|  | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatescountget"></a>
# **TeamsIdTemplatesCountGet**
> InlineResponse200 TeamsIdTemplatesCountGet (string id, string where = null)

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
    public class TeamsIdTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of Team.
                InlineResponse200 result = apiInstance.TeamsIdTemplatesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesdelete"></a>
# **TeamsIdTemplatesDelete**
> void TeamsIdTemplatesDelete (string id)

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
    public class TeamsIdTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all templates of this model.
                apiInstance.TeamsIdTemplatesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesfkdelete"></a>
# **TeamsIdTemplatesFkDelete**
> void TeamsIdTemplatesFkDelete (string id, string fk)

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
    public class TeamsIdTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.TeamsIdTemplatesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesfkget"></a>
# **TeamsIdTemplatesFkGet**
> Template TeamsIdTemplatesFkGet (string id, string fk)

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
    public class TeamsIdTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.TeamsIdTemplatesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesfkput"></a>
# **TeamsIdTemplatesFkPut**
> Template TeamsIdTemplatesFkPut (string id, string fk, Template data = null)

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
    public class TeamsIdTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.TeamsIdTemplatesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidtemplatesget"></a>
# **TeamsIdTemplatesGet**
> List<Template> TeamsIdTemplatesGet (string id, string filter = null)

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
    public class TeamsIdTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of Team.
                List&lt;Template&gt; result = apiInstance.TeamsIdTemplatesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkdesignscountget"></a>
# **TeamsIdTemplatesNkDesignsCountGet**
> InlineResponse200 TeamsIdTemplatesNkDesignsCountGet (string id, string nk, string where = null)

Counts designs of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designs of Template.
                InlineResponse200 result = apiInstance.TeamsIdTemplatesNkDesignsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkdesignsdelete"></a>
# **TeamsIdTemplatesNkDesignsDelete**
> void TeamsIdTemplatesNkDesignsDelete (string id, string nk)

Deletes all designs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkDesignsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.

            try
            {
                // Deletes all designs of this model.
                apiInstance.TeamsIdTemplatesNkDesignsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkdesignsfkdelete"></a>
# **TeamsIdTemplatesNkDesignsFkDelete**
> void TeamsIdTemplatesNkDesignsFkDelete (string id, string nk, string fk)

Delete a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Delete a related item by id for designs.
                apiInstance.TeamsIdTemplatesNkDesignsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for designs | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkdesignsfkget"></a>
# **TeamsIdTemplatesNkDesignsFkGet**
> Design TeamsIdTemplatesNkDesignsFkGet (string id, string nk, string fk)

Find a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Find a related item by id for designs.
                Design result = apiInstance.TeamsIdTemplatesNkDesignsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for designs | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkdesignsfkput"></a>
# **TeamsIdTemplatesNkDesignsFkPut**
> Design TeamsIdTemplatesNkDesignsFkPut (string id, string nk, string fk, Design data = null)

Update a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for designs
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for designs.
                Design result = apiInstance.TeamsIdTemplatesNkDesignsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for designs | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkdesignsget"></a>
# **TeamsIdTemplatesNkDesignsGet**
> List<Design> TeamsIdTemplatesNkDesignsGet (string id, string nk, string filter = null)

Queries designs of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designs of Template.
                List&lt;Design&gt; result = apiInstance.TeamsIdTemplatesNkDesignsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkdesignspost"></a>
# **TeamsIdTemplatesNkDesignsPost**
> Design TeamsIdTemplatesNkDesignsPost (string id, string nk, Design data = null)

Creates a new instance in designs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in designs of this model.
                Design result = apiInstance.TeamsIdTemplatesNkDesignsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmemberscountget"></a>
# **TeamsIdTemplatesNkMembersCountGet**
> InlineResponse200 TeamsIdTemplatesNkMembersCountGet (string id, string nk, string where = null)

Counts members of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts members of Template.
                InlineResponse200 result = apiInstance.TeamsIdTemplatesNkMembersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmembersdelete"></a>
# **TeamsIdTemplatesNkMembersDelete**
> void TeamsIdTemplatesNkMembersDelete (string id, string nk)

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
    public class TeamsIdTemplatesNkMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.

            try
            {
                // Deletes all members of this model.
                apiInstance.TeamsIdTemplatesNkMembersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmembersfkdelete"></a>
# **TeamsIdTemplatesNkMembersFkDelete**
> void TeamsIdTemplatesNkMembersFkDelete (string id, string nk, string fk)

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
    public class TeamsIdTemplatesNkMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Delete a related item by id for members.
                apiInstance.TeamsIdTemplatesNkMembersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmembersfkget"></a>
# **TeamsIdTemplatesNkMembersFkGet**
> TeamMember TeamsIdTemplatesNkMembersFkGet (string id, string nk, string fk)

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
    public class TeamsIdTemplatesNkMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Find a related item by id for members.
                TeamMember result = apiInstance.TeamsIdTemplatesNkMembersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for members | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmembersfkput"></a>
# **TeamsIdTemplatesNkMembersFkPut**
> TeamMember TeamsIdTemplatesNkMembersFkPut (string id, string nk, string fk, TeamMember data = null)

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
    public class TeamsIdTemplatesNkMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for members
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for members.
                TeamMember result = apiInstance.TeamsIdTemplatesNkMembersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
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

<a name="teamsidtemplatesnkmembersget"></a>
# **TeamsIdTemplatesNkMembersGet**
> List<TeamMember> TeamsIdTemplatesNkMembersGet (string id, string nk, string filter = null)

Queries members of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries members of Template.
                List&lt;TeamMember&gt; result = apiInstance.TeamsIdTemplatesNkMembersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmemberspost"></a>
# **TeamsIdTemplatesNkMembersPost**
> TeamMember TeamsIdTemplatesNkMembersPost (string id, string nk, TeamMember data = null)

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
    public class TeamsIdTemplatesNkMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in members of this model.
                TeamMember result = apiInstance.TeamsIdTemplatesNkMembersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmembersrelfkdelete"></a>
# **TeamsIdTemplatesNkMembersRelFkDelete**
> void TeamsIdTemplatesNkMembersRelFkDelete (string id, string nk, string fk)

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
    public class TeamsIdTemplatesNkMembersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Remove the members relation to an item by id.
                apiInstance.TeamsIdTemplatesNkMembersRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmembersrelfkhead"></a>
# **TeamsIdTemplatesNkMembersRelFkHead**
> bool? TeamsIdTemplatesNkMembersRelFkHead (string id, string nk, string fk)

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
    public class TeamsIdTemplatesNkMembersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Check the existence of members relation to an item by id.
                bool? result = apiInstance.TeamsIdTemplatesNkMembersRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for members | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkmembersrelfkput"></a>
# **TeamsIdTemplatesNkMembersRelFkPut**
> TemplateMember TeamsIdTemplatesNkMembersRelFkPut (string id, string nk, string fk, TemplateMember data = null)

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
    public class TeamsIdTemplatesNkMembersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for members
            var data = new TemplateMember(); // TemplateMember |  (optional) 

            try
            {
                // Add a related item by id for members.
                TemplateMember result = apiInstance.TeamsIdTemplatesNkMembersRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkMembersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for members | 
 **data** | [**TemplateMember**](TemplateMember.md)|  | [optional] 

### Return type

[**TemplateMember**](TemplateMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkpermissiondelete"></a>
# **TeamsIdTemplatesNkPermissionDelete**
> void TeamsIdTemplatesNkPermissionDelete (string id, string nk)

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
    public class TeamsIdTemplatesNkPermissionDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.

            try
            {
                // Deletes permission of this model.
                apiInstance.TeamsIdTemplatesNkPermissionDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPermissionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkpermissionget"></a>
# **TeamsIdTemplatesNkPermissionGet**
> TemplatePermissionSet TeamsIdTemplatesNkPermissionGet (string id, string nk, bool? refresh = null)

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
    public class TeamsIdTemplatesNkPermissionGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation permission.
                TemplatePermissionSet result = apiInstance.TeamsIdTemplatesNkPermissionGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPermissionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkpermissionpost"></a>
# **TeamsIdTemplatesNkPermissionPost**
> TemplatePermissionSet TeamsIdTemplatesNkPermissionPost (string id, string nk, TemplatePermissionSet data = null)

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
    public class TeamsIdTemplatesNkPermissionPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var data = new TemplatePermissionSet(); // TemplatePermissionSet |  (optional) 

            try
            {
                // Creates a new instance in permission of this model.
                TemplatePermissionSet result = apiInstance.TeamsIdTemplatesNkPermissionPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPermissionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)|  | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkpermissionput"></a>
# **TeamsIdTemplatesNkPermissionPut**
> TemplatePermissionSet TeamsIdTemplatesNkPermissionPut (string id, string nk, TemplatePermissionSet data = null)

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
    public class TeamsIdTemplatesNkPermissionPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var data = new TemplatePermissionSet(); // TemplatePermissionSet |  (optional) 

            try
            {
                // Update permission of this model.
                TemplatePermissionSet result = apiInstance.TeamsIdTemplatesNkPermissionPut(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPermissionPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)|  | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfolderscountget"></a>
# **TeamsIdTemplatesNkPortalFoldersCountGet**
> InlineResponse200 TeamsIdTemplatesNkPortalFoldersCountGet (string id, string nk, string where = null)

Counts portalFolders of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portalFolders of Template.
                InlineResponse200 result = apiInstance.TeamsIdTemplatesNkPortalFoldersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfoldersdelete"></a>
# **TeamsIdTemplatesNkPortalFoldersDelete**
> void TeamsIdTemplatesNkPortalFoldersDelete (string id, string nk)

Deletes all portalFolders of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.

            try
            {
                // Deletes all portalFolders of this model.
                apiInstance.TeamsIdTemplatesNkPortalFoldersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfoldersfkdelete"></a>
# **TeamsIdTemplatesNkPortalFoldersFkDelete**
> void TeamsIdTemplatesNkPortalFoldersFkDelete (string id, string nk, string fk)

Delete a related item by id for portalFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portalFolders

            try
            {
                // Delete a related item by id for portalFolders.
                apiInstance.TeamsIdTemplatesNkPortalFoldersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portalFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfoldersfkget"></a>
# **TeamsIdTemplatesNkPortalFoldersFkGet**
> PortalTemplateFolder TeamsIdTemplatesNkPortalFoldersFkGet (string id, string nk, string fk)

Find a related item by id for portalFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portalFolders

            try
            {
                // Find a related item by id for portalFolders.
                PortalTemplateFolder result = apiInstance.TeamsIdTemplatesNkPortalFoldersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portalFolders | 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfoldersfkput"></a>
# **TeamsIdTemplatesNkPortalFoldersFkPut**
> PortalTemplateFolder TeamsIdTemplatesNkPortalFoldersFkPut (string id, string nk, string fk, PortalTemplateFolder data = null)

Update a related item by id for portalFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portalFolders
            var data = new PortalTemplateFolder(); // PortalTemplateFolder |  (optional) 

            try
            {
                // Update a related item by id for portalFolders.
                PortalTemplateFolder result = apiInstance.TeamsIdTemplatesNkPortalFoldersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portalFolders | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)|  | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfoldersget"></a>
# **TeamsIdTemplatesNkPortalFoldersGet**
> List<PortalTemplateFolder> TeamsIdTemplatesNkPortalFoldersGet (string id, string nk, string filter = null)

Queries portalFolders of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portalFolders of Template.
                List&lt;PortalTemplateFolder&gt; result = apiInstance.TeamsIdTemplatesNkPortalFoldersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<PortalTemplateFolder>**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfolderspost"></a>
# **TeamsIdTemplatesNkPortalFoldersPost**
> PortalTemplateFolder TeamsIdTemplatesNkPortalFoldersPost (string id, string nk, PortalTemplateFolder data = null)

Creates a new instance in portalFolders of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var data = new PortalTemplateFolder(); // PortalTemplateFolder |  (optional) 

            try
            {
                // Creates a new instance in portalFolders of this model.
                PortalTemplateFolder result = apiInstance.TeamsIdTemplatesNkPortalFoldersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)|  | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfoldersrelfkdelete"></a>
# **TeamsIdTemplatesNkPortalFoldersRelFkDelete**
> void TeamsIdTemplatesNkPortalFoldersRelFkDelete (string id, string nk, string fk)

Remove the portalFolders relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portalFolders

            try
            {
                // Remove the portalFolders relation to an item by id.
                apiInstance.TeamsIdTemplatesNkPortalFoldersRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portalFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfoldersrelfkhead"></a>
# **TeamsIdTemplatesNkPortalFoldersRelFkHead**
> bool? TeamsIdTemplatesNkPortalFoldersRelFkHead (string id, string nk, string fk)

Check the existence of portalFolders relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portalFolders

            try
            {
                // Check the existence of portalFolders relation to an item by id.
                bool? result = apiInstance.TeamsIdTemplatesNkPortalFoldersRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portalFolders | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalfoldersrelfkput"></a>
# **TeamsIdTemplatesNkPortalFoldersRelFkPut**
> PortalTemplate TeamsIdTemplatesNkPortalFoldersRelFkPut (string id, string nk, string fk, PortalTemplate data = null)

Add a related item by id for portalFolders.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalFoldersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portalFolders
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Add a related item by id for portalFolders.
                PortalTemplate result = apiInstance.TeamsIdTemplatesNkPortalFoldersRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalFoldersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portalFolders | 
 **data** | [**PortalTemplate**](PortalTemplate.md)|  | [optional] 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalscountget"></a>
# **TeamsIdTemplatesNkPortalsCountGet**
> InlineResponse200 TeamsIdTemplatesNkPortalsCountGet (string id, string nk, string where = null)

Counts portals of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portals of Template.
                InlineResponse200 result = apiInstance.TeamsIdTemplatesNkPortalsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalsdelete"></a>
# **TeamsIdTemplatesNkPortalsDelete**
> void TeamsIdTemplatesNkPortalsDelete (string id, string nk)

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
    public class TeamsIdTemplatesNkPortalsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.

            try
            {
                // Deletes all portals of this model.
                apiInstance.TeamsIdTemplatesNkPortalsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalsfkdelete"></a>
# **TeamsIdTemplatesNkPortalsFkDelete**
> void TeamsIdTemplatesNkPortalsFkDelete (string id, string nk, string fk)

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
    public class TeamsIdTemplatesNkPortalsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Delete a related item by id for portals.
                apiInstance.TeamsIdTemplatesNkPortalsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalsfkget"></a>
# **TeamsIdTemplatesNkPortalsFkGet**
> Portal TeamsIdTemplatesNkPortalsFkGet (string id, string nk, string fk)

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
    public class TeamsIdTemplatesNkPortalsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Find a related item by id for portals.
                Portal result = apiInstance.TeamsIdTemplatesNkPortalsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalsfkput"></a>
# **TeamsIdTemplatesNkPortalsFkPut**
> Portal TeamsIdTemplatesNkPortalsFkPut (string id, string nk, string fk, Portal data = null)

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
    public class TeamsIdTemplatesNkPortalsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portals
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Update a related item by id for portals.
                Portal result = apiInstance.TeamsIdTemplatesNkPortalsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
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

<a name="teamsidtemplatesnkportalsget"></a>
# **TeamsIdTemplatesNkPortalsGet**
> List<Portal> TeamsIdTemplatesNkPortalsGet (string id, string nk, string filter = null)

Queries portals of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portals of Template.
                List&lt;Portal&gt; result = apiInstance.TeamsIdTemplatesNkPortalsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Portal>**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalspost"></a>
# **TeamsIdTemplatesNkPortalsPost**
> Portal TeamsIdTemplatesNkPortalsPost (string id, string nk, Portal data = null)

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
    public class TeamsIdTemplatesNkPortalsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Creates a new instance in portals of this model.
                Portal result = apiInstance.TeamsIdTemplatesNkPortalsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **data** | [**Portal**](Portal.md)|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalsrelfkdelete"></a>
# **TeamsIdTemplatesNkPortalsRelFkDelete**
> void TeamsIdTemplatesNkPortalsRelFkDelete (string id, string nk, string fk)

Remove the portals relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Remove the portals relation to an item by id.
                apiInstance.TeamsIdTemplatesNkPortalsRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalsrelfkhead"></a>
# **TeamsIdTemplatesNkPortalsRelFkHead**
> bool? TeamsIdTemplatesNkPortalsRelFkHead (string id, string nk, string fk)

Check the existence of portals relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Check the existence of portals relation to an item by id.
                bool? result = apiInstance.TeamsIdTemplatesNkPortalsRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portals | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkportalsrelfkput"></a>
# **TeamsIdTemplatesNkPortalsRelFkPut**
> PortalTemplate TeamsIdTemplatesNkPortalsRelFkPut (string id, string nk, string fk, PortalTemplate data = null)

Add a related item by id for portals.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkPortalsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for portals
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Add a related item by id for portals.
                PortalTemplate result = apiInstance.TeamsIdTemplatesNkPortalsRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkPortalsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for portals | 
 **data** | [**PortalTemplate**](PortalTemplate.md)|  | [optional] 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagscountget"></a>
# **TeamsIdTemplatesNkTagsCountGet**
> InlineResponse200 TeamsIdTemplatesNkTagsCountGet (string id, string nk, string where = null)

Counts tags of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts tags of Template.
                InlineResponse200 result = apiInstance.TeamsIdTemplatesNkTagsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagsdelete"></a>
# **TeamsIdTemplatesNkTagsDelete**
> void TeamsIdTemplatesNkTagsDelete (string id, string nk)

Deletes all tags of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.

            try
            {
                // Deletes all tags of this model.
                apiInstance.TeamsIdTemplatesNkTagsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagsfkdelete"></a>
# **TeamsIdTemplatesNkTagsFkDelete**
> void TeamsIdTemplatesNkTagsFkDelete (string id, string nk, string fk)

Delete a related item by id for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Delete a related item by id for tags.
                apiInstance.TeamsIdTemplatesNkTagsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for tags | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagsfkget"></a>
# **TeamsIdTemplatesNkTagsFkGet**
> Tag TeamsIdTemplatesNkTagsFkGet (string id, string nk, string fk)

Find a related item by id for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Find a related item by id for tags.
                Tag result = apiInstance.TeamsIdTemplatesNkTagsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for tags | 

### Return type

[**Tag**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagsfkput"></a>
# **TeamsIdTemplatesNkTagsFkPut**
> Tag TeamsIdTemplatesNkTagsFkPut (string id, string nk, string fk, Tag data = null)

Update a related item by id for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for tags
            var data = new Tag(); // Tag |  (optional) 

            try
            {
                // Update a related item by id for tags.
                Tag result = apiInstance.TeamsIdTemplatesNkTagsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for tags | 
 **data** | [**Tag**](Tag.md)|  | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagsget"></a>
# **TeamsIdTemplatesNkTagsGet**
> List<Tag> TeamsIdTemplatesNkTagsGet (string id, string nk, string filter = null)

Queries tags of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries tags of Template.
                List&lt;Tag&gt; result = apiInstance.TeamsIdTemplatesNkTagsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Tag>**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagspost"></a>
# **TeamsIdTemplatesNkTagsPost**
> Tag TeamsIdTemplatesNkTagsPost (string id, string nk, Tag data = null)

Creates a new instance in tags of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var data = new Tag(); // Tag |  (optional) 

            try
            {
                // Creates a new instance in tags of this model.
                Tag result = apiInstance.TeamsIdTemplatesNkTagsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **data** | [**Tag**](Tag.md)|  | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagsrelfkdelete"></a>
# **TeamsIdTemplatesNkTagsRelFkDelete**
> void TeamsIdTemplatesNkTagsRelFkDelete (string id, string nk, string fk)

Remove the tags relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Remove the tags relation to an item by id.
                apiInstance.TeamsIdTemplatesNkTagsRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for tags | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagsrelfkhead"></a>
# **TeamsIdTemplatesNkTagsRelFkHead**
> bool? TeamsIdTemplatesNkTagsRelFkHead (string id, string nk, string fk)

Check the existence of tags relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Check the existence of tags relation to an item by id.
                bool? result = apiInstance.TeamsIdTemplatesNkTagsRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for tags | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktagsrelfkput"></a>
# **TeamsIdTemplatesNkTagsRelFkPut**
> TemplateTag TeamsIdTemplatesNkTagsRelFkPut (string id, string nk, string fk, TemplateTag data = null)

Add a related item by id for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTagsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for tags
            var data = new TemplateTag(); // TemplateTag |  (optional) 

            try
            {
                // Add a related item by id for tags.
                TemplateTag result = apiInstance.TeamsIdTemplatesNkTagsRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTagsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for tags | 
 **data** | [**TemplateTag**](TemplateTag.md)|  | [optional] 

### Return type

[**TemplateTag**](TemplateTag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkteamfolderget"></a>
# **TeamsIdTemplatesNkTeamFolderGet**
> TeamTemplateFolder TeamsIdTemplatesNkTeamFolderGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation teamFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTeamFolderGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation teamFolder.
                TeamTemplateFolder result = apiInstance.TeamsIdTemplatesNkTeamFolderGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTeamFolderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkteamget"></a>
# **TeamsIdTemplatesNkTeamGet**
> Team TeamsIdTemplatesNkTeamGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamsIdTemplatesNkTeamGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktemplatememberscountget"></a>
# **TeamsIdTemplatesNkTemplateMembersCountGet**
> InlineResponse200 TeamsIdTemplatesNkTemplateMembersCountGet (string id, string nk, string where = null)

Counts templateMembers of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTemplateMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templateMembers of Template.
                InlineResponse200 result = apiInstance.TeamsIdTemplatesNkTemplateMembersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTemplateMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktemplatemembersdelete"></a>
# **TeamsIdTemplatesNkTemplateMembersDelete**
> void TeamsIdTemplatesNkTemplateMembersDelete (string id, string nk)

Deletes all templateMembers of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTemplateMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.

            try
            {
                // Deletes all templateMembers of this model.
                apiInstance.TeamsIdTemplatesNkTemplateMembersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTemplateMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktemplatemembersfkdelete"></a>
# **TeamsIdTemplatesNkTemplateMembersFkDelete**
> void TeamsIdTemplatesNkTemplateMembersFkDelete (string id, string nk, string fk)

Delete a related item by id for templateMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTemplateMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for templateMembers

            try
            {
                // Delete a related item by id for templateMembers.
                apiInstance.TeamsIdTemplatesNkTemplateMembersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTemplateMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for templateMembers | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktemplatemembersfkget"></a>
# **TeamsIdTemplatesNkTemplateMembersFkGet**
> TemplateMember TeamsIdTemplatesNkTemplateMembersFkGet (string id, string nk, string fk)

Find a related item by id for templateMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTemplateMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for templateMembers

            try
            {
                // Find a related item by id for templateMembers.
                TemplateMember result = apiInstance.TeamsIdTemplatesNkTemplateMembersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTemplateMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for templateMembers | 

### Return type

[**TemplateMember**](TemplateMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktemplatemembersfkput"></a>
# **TeamsIdTemplatesNkTemplateMembersFkPut**
> TemplateMember TeamsIdTemplatesNkTemplateMembersFkPut (string id, string nk, string fk, TemplateMember data = null)

Update a related item by id for templateMembers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTemplateMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var fk = fk_example;  // string | Foreign key for templateMembers
            var data = new TemplateMember(); // TemplateMember |  (optional) 

            try
            {
                // Update a related item by id for templateMembers.
                TemplateMember result = apiInstance.TeamsIdTemplatesNkTemplateMembersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTemplateMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **fk** | **string**| Foreign key for templateMembers | 
 **data** | [**TemplateMember**](TemplateMember.md)|  | [optional] 

### Return type

[**TemplateMember**](TemplateMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktemplatemembersget"></a>
# **TeamsIdTemplatesNkTemplateMembersGet**
> List<TemplateMember> TeamsIdTemplatesNkTemplateMembersGet (string id, string nk, string filter = null)

Queries templateMembers of Template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTemplateMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templateMembers of Template.
                List&lt;TemplateMember&gt; result = apiInstance.TeamsIdTemplatesNkTemplateMembersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTemplateMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TemplateMember>**](TemplateMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnktemplatememberspost"></a>
# **TeamsIdTemplatesNkTemplateMembersPost**
> TemplateMember TeamsIdTemplatesNkTemplateMembersPost (string id, string nk, TemplateMember data = null)

Creates a new instance in templateMembers of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkTemplateMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var data = new TemplateMember(); // TemplateMember |  (optional) 

            try
            {
                // Creates a new instance in templateMembers of this model.
                TemplateMember result = apiInstance.TeamsIdTemplatesNkTemplateMembersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkTemplateMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **data** | [**TemplateMember**](TemplateMember.md)|  | [optional] 

### Return type

[**TemplateMember**](TemplateMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkuploaderget"></a>
# **TeamsIdTemplatesNkUploaderGet**
> TeamMember TeamsIdTemplatesNkUploaderGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation uploader.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkUploaderGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation uploader.
                TeamMember result = apiInstance.TeamsIdTemplatesNkUploaderGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkUploaderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatesnkworkflowget"></a>
# **TeamsIdTemplatesNkWorkflowGet**
> Workflow TeamsIdTemplatesNkWorkflowGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation workflow.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesNkWorkflowGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var nk = nk_example;  // string | Foreign key for templates.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation workflow.
                Workflow result = apiInstance.TeamsIdTemplatesNkWorkflowGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesNkWorkflowGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **nk** | **string**| Foreign key for templates. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplatespost"></a>
# **TeamsIdTemplatesPost**
> Template TeamsIdTemplatesPost (string id, Template data = null)

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
    public class TeamsIdTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.TeamsIdTemplatesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidtemplateswithdesignsget"></a>
# **TeamsIdTemplatesWithDesignsGet**
> List<Template> TeamsIdTemplatesWithDesignsGet (string id, string id2, string filter = null)

List Templates with Designs for this Team

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsIdTemplatesWithDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var id2 = id_example;  // string | Team id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // List Templates with Designs for this Team
                List&lt;Template&gt; result = apiInstance.TeamsIdTemplatesWithDesignsGet(id, id2, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdTemplatesWithDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **id2** | **string**| Team id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidworkflowscountget"></a>
# **TeamsIdWorkflowsCountGet**
> InlineResponse200 TeamsIdWorkflowsCountGet (string id, string where = null)

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
    public class TeamsIdWorkflowsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts workflows of Team.
                InlineResponse200 result = apiInstance.TeamsIdWorkflowsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdWorkflowsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidworkflowsdelete"></a>
# **TeamsIdWorkflowsDelete**
> void TeamsIdWorkflowsDelete (string id)

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
    public class TeamsIdWorkflowsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id

            try
            {
                // Deletes all workflows of this model.
                apiInstance.TeamsIdWorkflowsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdWorkflowsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidworkflowsfkdelete"></a>
# **TeamsIdWorkflowsFkDelete**
> void TeamsIdWorkflowsFkDelete (string id, string fk)

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
    public class TeamsIdWorkflowsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for workflows

            try
            {
                // Delete a related item by id for workflows.
                apiInstance.TeamsIdWorkflowsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdWorkflowsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for workflows | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidworkflowsfkget"></a>
# **TeamsIdWorkflowsFkGet**
> Workflow TeamsIdWorkflowsFkGet (string id, string fk)

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
    public class TeamsIdWorkflowsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for workflows

            try
            {
                // Find a related item by id for workflows.
                Workflow result = apiInstance.TeamsIdWorkflowsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdWorkflowsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **fk** | **string**| Foreign key for workflows | 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidworkflowsfkput"></a>
# **TeamsIdWorkflowsFkPut**
> Workflow TeamsIdWorkflowsFkPut (string id, string fk, Workflow data = null)

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
    public class TeamsIdWorkflowsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var fk = fk_example;  // string | Foreign key for workflows
            var data = new Workflow(); // Workflow |  (optional) 

            try
            {
                // Update a related item by id for workflows.
                Workflow result = apiInstance.TeamsIdWorkflowsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdWorkflowsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
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

<a name="teamsidworkflowsget"></a>
# **TeamsIdWorkflowsGet**
> List<Workflow> TeamsIdWorkflowsGet (string id, string filter = null)

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
    public class TeamsIdWorkflowsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries workflows of Team.
                List&lt;Workflow&gt; result = apiInstance.TeamsIdWorkflowsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdWorkflowsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Workflow>**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsidworkflowspost"></a>
# **TeamsIdWorkflowsPost**
> Workflow TeamsIdWorkflowsPost (string id, Workflow data = null)

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
    public class TeamsIdWorkflowsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var id = id_example;  // string | Team id
            var data = new Workflow(); // Workflow |  (optional) 

            try
            {
                // Creates a new instance in workflows of this model.
                Workflow result = apiInstance.TeamsIdWorkflowsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsIdWorkflowsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Team id | 
 **data** | [**Workflow**](Workflow.md)|  | [optional] 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsnamenameexistsget"></a>
# **TeamsNameNameExistsGet**
> InlineResponse2001 TeamsNameNameExistsGet (string name)

Define whether team exists or not

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsNameNameExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var name = name_example;  // string | Team name

            try
            {
                // Define whether team exists or not
                InlineResponse2001 result = apiInstance.TeamsNameNameExistsGet(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsNameNameExistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Team name | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamspatch"></a>
# **TeamsPatch**
> Team TeamsPatch (Team data = null)

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
    public class TeamsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var data = new Team(); // Team | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                Team result = apiInstance.TeamsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Team**](Team.md)| Model instance data | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamspost"></a>
# **TeamsPost**
> Team TeamsPost (Team data = null)

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
    public class TeamsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var data = new Team(); // Team | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                Team result = apiInstance.TeamsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Team**](Team.md)| Model instance data | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsput"></a>
# **TeamsPut**
> Team TeamsPut (Team data = null)

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
    public class TeamsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var data = new Team(); // Team | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Team result = apiInstance.TeamsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Team**](Team.md)| Model instance data | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsreplaceorcreatepost"></a>
# **TeamsReplaceOrCreatePost**
> Team TeamsReplaceOrCreatePost (Team data = null)

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
    public class TeamsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var data = new Team(); // Team | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Team result = apiInstance.TeamsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Team**](Team.md)| Model instance data | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamssubdomainsubdomainexistsget"></a>
# **TeamsSubdomainSubdomainExistsGet**
> InlineResponse2001 TeamsSubdomainSubdomainExistsGet (string subdomain)

Define whether team exists or not

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamsSubdomainSubdomainExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var subdomain = subdomain_example;  // string | Team subdomain

            try
            {
                // Define whether team exists or not
                InlineResponse2001 result = apiInstance.TeamsSubdomainSubdomainExistsGet(subdomain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsSubdomainSubdomainExistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subdomain** | **string**| Team subdomain | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsupdatepost"></a>
# **TeamsUpdatePost**
> InlineResponse2002 TeamsUpdatePost (string where = null, Team data = null)

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
    public class TeamsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Team(); // Team | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.TeamsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Team**](Team.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsupsertwithwherepost"></a>
# **TeamsUpsertWithWherePost**
> Team TeamsUpsertWithWherePost (string where = null, Team data = null)

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
    public class TeamsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Team(); // Team | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                Team result = apiInstance.TeamsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Team**](Team.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

