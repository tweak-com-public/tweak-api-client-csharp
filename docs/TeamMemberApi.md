# TweakApi.Api.TeamMemberApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamMembersChangeStreamGet**](TeamMemberApi.md#teammemberschangestreamget) | **GET** /TeamMembers/change-stream | Create a change stream.
[**TeamMembersChangeStreamPost**](TeamMemberApi.md#teammemberschangestreampost) | **POST** /TeamMembers/change-stream | Create a change stream.
[**TeamMembersCountGet**](TeamMemberApi.md#teammemberscountget) | **GET** /TeamMembers/count | Count instances of the model matched by where from the data source.
[**TeamMembersFindOneGet**](TeamMemberApi.md#teammembersfindoneget) | **GET** /TeamMembers/findOne | Find first instance of the model matched by filter from the data source.
[**TeamMembersGet**](TeamMemberApi.md#teammembersget) | **GET** /TeamMembers | Find all instances of the model matched by filter from the data source.
[**TeamMembersIdAssignedDesignsCountGet**](TeamMemberApi.md#teammembersidassigneddesignscountget) | **GET** /TeamMembers/{id}/assignedDesigns/count | Counts assignedDesigns of TeamMember.
[**TeamMembersIdAssignedDesignsDelete**](TeamMemberApi.md#teammembersidassigneddesignsdelete) | **DELETE** /TeamMembers/{id}/assignedDesigns | Deletes all assignedDesigns of this model.
[**TeamMembersIdAssignedDesignsFkDelete**](TeamMemberApi.md#teammembersidassigneddesignsfkdelete) | **DELETE** /TeamMembers/{id}/assignedDesigns/{fk} | Delete a related item by id for assignedDesigns.
[**TeamMembersIdAssignedDesignsFkGet**](TeamMemberApi.md#teammembersidassigneddesignsfkget) | **GET** /TeamMembers/{id}/assignedDesigns/{fk} | Find a related item by id for assignedDesigns.
[**TeamMembersIdAssignedDesignsFkPut**](TeamMemberApi.md#teammembersidassigneddesignsfkput) | **PUT** /TeamMembers/{id}/assignedDesigns/{fk} | Update a related item by id for assignedDesigns.
[**TeamMembersIdAssignedDesignsGet**](TeamMemberApi.md#teammembersidassigneddesignsget) | **GET** /TeamMembers/{id}/assignedDesigns | Queries assignedDesigns of TeamMember.
[**TeamMembersIdAssignedDesignsPost**](TeamMemberApi.md#teammembersidassigneddesignspost) | **POST** /TeamMembers/{id}/assignedDesigns | Creates a new instance in assignedDesigns of this model.
[**TeamMembersIdCommentedDesignsCountGet**](TeamMemberApi.md#teammembersidcommenteddesignscountget) | **GET** /TeamMembers/{id}/commentedDesigns/count | Counts commentedDesigns of TeamMember.
[**TeamMembersIdCommentedDesignsDelete**](TeamMemberApi.md#teammembersidcommenteddesignsdelete) | **DELETE** /TeamMembers/{id}/commentedDesigns | Deletes all commentedDesigns of this model.
[**TeamMembersIdCommentedDesignsFkDelete**](TeamMemberApi.md#teammembersidcommenteddesignsfkdelete) | **DELETE** /TeamMembers/{id}/commentedDesigns/{fk} | Delete a related item by id for commentedDesigns.
[**TeamMembersIdCommentedDesignsFkGet**](TeamMemberApi.md#teammembersidcommenteddesignsfkget) | **GET** /TeamMembers/{id}/commentedDesigns/{fk} | Find a related item by id for commentedDesigns.
[**TeamMembersIdCommentedDesignsFkPut**](TeamMemberApi.md#teammembersidcommenteddesignsfkput) | **PUT** /TeamMembers/{id}/commentedDesigns/{fk} | Update a related item by id for commentedDesigns.
[**TeamMembersIdCommentedDesignsGet**](TeamMemberApi.md#teammembersidcommenteddesignsget) | **GET** /TeamMembers/{id}/commentedDesigns | Queries commentedDesigns of TeamMember.
[**TeamMembersIdCommentedDesignsPost**](TeamMemberApi.md#teammembersidcommenteddesignspost) | **POST** /TeamMembers/{id}/commentedDesigns | Creates a new instance in commentedDesigns of this model.
[**TeamMembersIdCommentedDesignsRelFkDelete**](TeamMemberApi.md#teammembersidcommenteddesignsrelfkdelete) | **DELETE** /TeamMembers/{id}/commentedDesigns/rel/{fk} | Remove the commentedDesigns relation to an item by id.
[**TeamMembersIdCommentedDesignsRelFkHead**](TeamMemberApi.md#teammembersidcommenteddesignsrelfkhead) | **HEAD** /TeamMembers/{id}/commentedDesigns/rel/{fk} | Check the existence of commentedDesigns relation to an item by id.
[**TeamMembersIdCommentedDesignsRelFkPut**](TeamMemberApi.md#teammembersidcommenteddesignsrelfkput) | **PUT** /TeamMembers/{id}/commentedDesigns/rel/{fk} | Add a related item by id for commentedDesigns.
[**TeamMembersIdCustomerGet**](TeamMemberApi.md#teammembersidcustomerget) | **GET** /TeamMembers/{id}/customer | Fetches belongsTo relation customer.
[**TeamMembersIdDelete**](TeamMemberApi.md#teammembersiddelete) | **DELETE** /TeamMembers/{id} | Delete a model instance by {{id}} from the data source.
[**TeamMembersIdDesignCommentsCountGet**](TeamMemberApi.md#teammembersiddesigncommentscountget) | **GET** /TeamMembers/{id}/designComments/count | Counts designComments of TeamMember.
[**TeamMembersIdDesignCommentsDelete**](TeamMemberApi.md#teammembersiddesigncommentsdelete) | **DELETE** /TeamMembers/{id}/designComments | Deletes all designComments of this model.
[**TeamMembersIdDesignCommentsFkDelete**](TeamMemberApi.md#teammembersiddesigncommentsfkdelete) | **DELETE** /TeamMembers/{id}/designComments/{fk} | Delete a related item by id for designComments.
[**TeamMembersIdDesignCommentsFkGet**](TeamMemberApi.md#teammembersiddesigncommentsfkget) | **GET** /TeamMembers/{id}/designComments/{fk} | Find a related item by id for designComments.
[**TeamMembersIdDesignCommentsFkPut**](TeamMemberApi.md#teammembersiddesigncommentsfkput) | **PUT** /TeamMembers/{id}/designComments/{fk} | Update a related item by id for designComments.
[**TeamMembersIdDesignCommentsGet**](TeamMemberApi.md#teammembersiddesigncommentsget) | **GET** /TeamMembers/{id}/designComments | Queries designComments of TeamMember.
[**TeamMembersIdDesignCommentsPost**](TeamMemberApi.md#teammembersiddesigncommentspost) | **POST** /TeamMembers/{id}/designComments | Creates a new instance in designComments of this model.
[**TeamMembersIdDesignFoldersCountGet**](TeamMemberApi.md#teammembersiddesignfolderscountget) | **GET** /TeamMembers/{id}/designFolders/count | Counts designFolders of TeamMember.
[**TeamMembersIdDesignFoldersDelete**](TeamMemberApi.md#teammembersiddesignfoldersdelete) | **DELETE** /TeamMembers/{id}/designFolders | Deletes all designFolders of this model.
[**TeamMembersIdDesignFoldersFkDelete**](TeamMemberApi.md#teammembersiddesignfoldersfkdelete) | **DELETE** /TeamMembers/{id}/designFolders/{fk} | Delete a related item by id for designFolders.
[**TeamMembersIdDesignFoldersFkGet**](TeamMemberApi.md#teammembersiddesignfoldersfkget) | **GET** /TeamMembers/{id}/designFolders/{fk} | Find a related item by id for designFolders.
[**TeamMembersIdDesignFoldersFkPut**](TeamMemberApi.md#teammembersiddesignfoldersfkput) | **PUT** /TeamMembers/{id}/designFolders/{fk} | Update a related item by id for designFolders.
[**TeamMembersIdDesignFoldersGet**](TeamMemberApi.md#teammembersiddesignfoldersget) | **GET** /TeamMembers/{id}/designFolders | Queries designFolders of TeamMember.
[**TeamMembersIdDesignFoldersPost**](TeamMemberApi.md#teammembersiddesignfolderspost) | **POST** /TeamMembers/{id}/designFolders | Creates a new instance in designFolders of this model.
[**TeamMembersIdDesignSharesCountGet**](TeamMemberApi.md#teammembersiddesignsharescountget) | **GET** /TeamMembers/{id}/designShares/count | Counts designShares of TeamMember.
[**TeamMembersIdDesignSharesDelete**](TeamMemberApi.md#teammembersiddesignsharesdelete) | **DELETE** /TeamMembers/{id}/designShares | Deletes all designShares of this model.
[**TeamMembersIdDesignSharesFkDelete**](TeamMemberApi.md#teammembersiddesignsharesfkdelete) | **DELETE** /TeamMembers/{id}/designShares/{fk} | Delete a related item by id for designShares.
[**TeamMembersIdDesignSharesFkGet**](TeamMemberApi.md#teammembersiddesignsharesfkget) | **GET** /TeamMembers/{id}/designShares/{fk} | Find a related item by id for designShares.
[**TeamMembersIdDesignSharesFkPut**](TeamMemberApi.md#teammembersiddesignsharesfkput) | **PUT** /TeamMembers/{id}/designShares/{fk} | Update a related item by id for designShares.
[**TeamMembersIdDesignSharesGet**](TeamMemberApi.md#teammembersiddesignsharesget) | **GET** /TeamMembers/{id}/designShares | Queries designShares of TeamMember.
[**TeamMembersIdDesignSharesPost**](TeamMemberApi.md#teammembersiddesignsharespost) | **POST** /TeamMembers/{id}/designShares | Creates a new instance in designShares of this model.
[**TeamMembersIdExistsGet**](TeamMemberApi.md#teammembersidexistsget) | **GET** /TeamMembers/{id}/exists | Check whether a model instance exists in the data source.
[**TeamMembersIdGet**](TeamMemberApi.md#teammembersidget) | **GET** /TeamMembers/{id} | Find a model instance by {{id}} from the data source.
[**TeamMembersIdHead**](TeamMemberApi.md#teammembersidhead) | **HEAD** /TeamMembers/{id} | Check whether a model instance exists in the data source.
[**TeamMembersIdImageFoldersCountGet**](TeamMemberApi.md#teammembersidimagefolderscountget) | **GET** /TeamMembers/{id}/imageFolders/count | Counts imageFolders of TeamMember.
[**TeamMembersIdImageFoldersDelete**](TeamMemberApi.md#teammembersidimagefoldersdelete) | **DELETE** /TeamMembers/{id}/imageFolders | Deletes all imageFolders of this model.
[**TeamMembersIdImageFoldersFkDelete**](TeamMemberApi.md#teammembersidimagefoldersfkdelete) | **DELETE** /TeamMembers/{id}/imageFolders/{fk} | Delete a related item by id for imageFolders.
[**TeamMembersIdImageFoldersFkGet**](TeamMemberApi.md#teammembersidimagefoldersfkget) | **GET** /TeamMembers/{id}/imageFolders/{fk} | Find a related item by id for imageFolders.
[**TeamMembersIdImageFoldersFkPut**](TeamMemberApi.md#teammembersidimagefoldersfkput) | **PUT** /TeamMembers/{id}/imageFolders/{fk} | Update a related item by id for imageFolders.
[**TeamMembersIdImageFoldersGet**](TeamMemberApi.md#teammembersidimagefoldersget) | **GET** /TeamMembers/{id}/imageFolders | Queries imageFolders of TeamMember.
[**TeamMembersIdImageFoldersPost**](TeamMemberApi.md#teammembersidimagefolderspost) | **POST** /TeamMembers/{id}/imageFolders | Creates a new instance in imageFolders of this model.
[**TeamMembersIdImageFoldersRelFkDelete**](TeamMemberApi.md#teammembersidimagefoldersrelfkdelete) | **DELETE** /TeamMembers/{id}/imageFolders/rel/{fk} | Remove the imageFolders relation to an item by id.
[**TeamMembersIdImageFoldersRelFkHead**](TeamMemberApi.md#teammembersidimagefoldersrelfkhead) | **HEAD** /TeamMembers/{id}/imageFolders/rel/{fk} | Check the existence of imageFolders relation to an item by id.
[**TeamMembersIdImageFoldersRelFkPut**](TeamMemberApi.md#teammembersidimagefoldersrelfkput) | **PUT** /TeamMembers/{id}/imageFolders/rel/{fk} | Add a related item by id for imageFolders.
[**TeamMembersIdInvitationTicketsCountGet**](TeamMemberApi.md#teammembersidinvitationticketscountget) | **GET** /TeamMembers/{id}/invitationTickets/count | Counts invitationTickets of TeamMember.
[**TeamMembersIdInvitationTicketsDelete**](TeamMemberApi.md#teammembersidinvitationticketsdelete) | **DELETE** /TeamMembers/{id}/invitationTickets | Deletes all invitationTickets of this model.
[**TeamMembersIdInvitationTicketsFkDelete**](TeamMemberApi.md#teammembersidinvitationticketsfkdelete) | **DELETE** /TeamMembers/{id}/invitationTickets/{fk} | Delete a related item by id for invitationTickets.
[**TeamMembersIdInvitationTicketsFkGet**](TeamMemberApi.md#teammembersidinvitationticketsfkget) | **GET** /TeamMembers/{id}/invitationTickets/{fk} | Find a related item by id for invitationTickets.
[**TeamMembersIdInvitationTicketsFkPut**](TeamMemberApi.md#teammembersidinvitationticketsfkput) | **PUT** /TeamMembers/{id}/invitationTickets/{fk} | Update a related item by id for invitationTickets.
[**TeamMembersIdInvitationTicketsGet**](TeamMemberApi.md#teammembersidinvitationticketsget) | **GET** /TeamMembers/{id}/invitationTickets | Queries invitationTickets of TeamMember.
[**TeamMembersIdInvitationTicketsPost**](TeamMemberApi.md#teammembersidinvitationticketspost) | **POST** /TeamMembers/{id}/invitationTickets | Creates a new instance in invitationTickets of this model.
[**TeamMembersIdInviteInviteePost**](TeamMemberApi.md#teammembersidinviteinviteepost) | **POST** /TeamMembers/{id}/invite/{invitee} | Invite somebody to join the team
[**TeamMembersIdNotificationsCountGet**](TeamMemberApi.md#teammembersidnotificationscountget) | **GET** /TeamMembers/{id}/notifications/count | Counts notifications of TeamMember.
[**TeamMembersIdNotificationsDelete**](TeamMemberApi.md#teammembersidnotificationsdelete) | **DELETE** /TeamMembers/{id}/notifications | Deletes all notifications of this model.
[**TeamMembersIdNotificationsFkDelete**](TeamMemberApi.md#teammembersidnotificationsfkdelete) | **DELETE** /TeamMembers/{id}/notifications/{fk} | Delete a related item by id for notifications.
[**TeamMembersIdNotificationsFkGet**](TeamMemberApi.md#teammembersidnotificationsfkget) | **GET** /TeamMembers/{id}/notifications/{fk} | Find a related item by id for notifications.
[**TeamMembersIdNotificationsFkPut**](TeamMemberApi.md#teammembersidnotificationsfkput) | **PUT** /TeamMembers/{id}/notifications/{fk} | Update a related item by id for notifications.
[**TeamMembersIdNotificationsGet**](TeamMemberApi.md#teammembersidnotificationsget) | **GET** /TeamMembers/{id}/notifications | Queries notifications of TeamMember.
[**TeamMembersIdNotificationsPost**](TeamMemberApi.md#teammembersidnotificationspost) | **POST** /TeamMembers/{id}/notifications | Creates a new instance in notifications of this model.
[**TeamMembersIdPatch**](TeamMemberApi.md#teammembersidpatch) | **PATCH** /TeamMembers/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamMembersIdPortalsAvailableGet**](TeamMemberApi.md#teammembersidportalsavailableget) | **GET** /TeamMembers/{id}/portals/available | Find all available Portals
[**TeamMembersIdPortalsCountGet**](TeamMemberApi.md#teammembersidportalscountget) | **GET** /TeamMembers/{id}/portals/count | Counts portals of TeamMember.
[**TeamMembersIdPortalsDelete**](TeamMemberApi.md#teammembersidportalsdelete) | **DELETE** /TeamMembers/{id}/portals | Deletes all portals of this model.
[**TeamMembersIdPortalsFkAvailableGet**](TeamMemberApi.md#teammembersidportalsfkavailableget) | **GET** /TeamMembers/{id}/portals/{fk}/available | Find available Portal by id
[**TeamMembersIdPortalsFkDelete**](TeamMemberApi.md#teammembersidportalsfkdelete) | **DELETE** /TeamMembers/{id}/portals/{fk} | Delete a related item by id for portals.
[**TeamMembersIdPortalsFkGet**](TeamMemberApi.md#teammembersidportalsfkget) | **GET** /TeamMembers/{id}/portals/{fk} | Find a related item by id for portals.
[**TeamMembersIdPortalsFkLogoPut**](TeamMemberApi.md#teammembersidportalsfklogoput) | **PUT** /TeamMembers/{id}/portals/{fk}/logo | Change Portal logo
[**TeamMembersIdPortalsFkPut**](TeamMemberApi.md#teammembersidportalsfkput) | **PUT** /TeamMembers/{id}/portals/{fk} | Update a related item by id for portals.
[**TeamMembersIdPortalsGet**](TeamMemberApi.md#teammembersidportalsget) | **GET** /TeamMembers/{id}/portals | Queries portals of TeamMember.
[**TeamMembersIdPortalsNkDesignsFkFlashvarsGet**](TeamMemberApi.md#teammembersidportalsnkdesignsfkflashvarsget) | **GET** /TeamMembers/{id}/portals/{nk}/designs/{fk}/flashvars | Find Design FlashVars within available Portal by id
[**TeamMembersIdPortalsNkTemplatesFkFlashvarsGet**](TeamMemberApi.md#teammembersidportalsnktemplatesfkflashvarsget) | **GET** /TeamMembers/{id}/portals/{nk}/templates/{fk}/flashvars | Find Template FlashVars within available Portal by id
[**TeamMembersIdPortalsPost**](TeamMemberApi.md#teammembersidportalspost) | **POST** /TeamMembers/{id}/portals | Creates a new instance in portals of this model.
[**TeamMembersIdPortalsRelFkDelete**](TeamMemberApi.md#teammembersidportalsrelfkdelete) | **DELETE** /TeamMembers/{id}/portals/rel/{fk} | Remove the portals relation to an item by id.
[**TeamMembersIdPortalsRelFkHead**](TeamMemberApi.md#teammembersidportalsrelfkhead) | **HEAD** /TeamMembers/{id}/portals/rel/{fk} | Check the existence of portals relation to an item by id.
[**TeamMembersIdPortalsRelFkPut**](TeamMemberApi.md#teammembersidportalsrelfkput) | **PUT** /TeamMembers/{id}/portals/rel/{fk} | Add a related item by id for portals.
[**TeamMembersIdPut**](TeamMemberApi.md#teammembersidput) | **PUT** /TeamMembers/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamMembersIdReplacePost**](TeamMemberApi.md#teammembersidreplacepost) | **POST** /TeamMembers/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamMembersIdRequestedDesignExportsCountGet**](TeamMemberApi.md#teammembersidrequesteddesignexportscountget) | **GET** /TeamMembers/{id}/requestedDesignExports/count | Counts requestedDesignExports of TeamMember.
[**TeamMembersIdRequestedDesignExportsDelete**](TeamMemberApi.md#teammembersidrequesteddesignexportsdelete) | **DELETE** /TeamMembers/{id}/requestedDesignExports | Deletes all requestedDesignExports of this model.
[**TeamMembersIdRequestedDesignExportsFkDelete**](TeamMemberApi.md#teammembersidrequesteddesignexportsfkdelete) | **DELETE** /TeamMembers/{id}/requestedDesignExports/{fk} | Delete a related item by id for requestedDesignExports.
[**TeamMembersIdRequestedDesignExportsFkGet**](TeamMemberApi.md#teammembersidrequesteddesignexportsfkget) | **GET** /TeamMembers/{id}/requestedDesignExports/{fk} | Find a related item by id for requestedDesignExports.
[**TeamMembersIdRequestedDesignExportsFkPut**](TeamMemberApi.md#teammembersidrequesteddesignexportsfkput) | **PUT** /TeamMembers/{id}/requestedDesignExports/{fk} | Update a related item by id for requestedDesignExports.
[**TeamMembersIdRequestedDesignExportsGet**](TeamMemberApi.md#teammembersidrequesteddesignexportsget) | **GET** /TeamMembers/{id}/requestedDesignExports | Queries requestedDesignExports of TeamMember.
[**TeamMembersIdRequestedDesignExportsPost**](TeamMemberApi.md#teammembersidrequesteddesignexportspost) | **POST** /TeamMembers/{id}/requestedDesignExports | Creates a new instance in requestedDesignExports of this model.
[**TeamMembersIdRequestedDesignsCountGet**](TeamMemberApi.md#teammembersidrequesteddesignscountget) | **GET** /TeamMembers/{id}/requestedDesigns/count | Counts requestedDesigns of TeamMember.
[**TeamMembersIdRequestedDesignsDelete**](TeamMemberApi.md#teammembersidrequesteddesignsdelete) | **DELETE** /TeamMembers/{id}/requestedDesigns | Deletes all requestedDesigns of this model.
[**TeamMembersIdRequestedDesignsFkDelete**](TeamMemberApi.md#teammembersidrequesteddesignsfkdelete) | **DELETE** /TeamMembers/{id}/requestedDesigns/{fk} | Delete a related item by id for requestedDesigns.
[**TeamMembersIdRequestedDesignsFkGet**](TeamMemberApi.md#teammembersidrequesteddesignsfkget) | **GET** /TeamMembers/{id}/requestedDesigns/{fk} | Find a related item by id for requestedDesigns.
[**TeamMembersIdRequestedDesignsFkPut**](TeamMemberApi.md#teammembersidrequesteddesignsfkput) | **PUT** /TeamMembers/{id}/requestedDesigns/{fk} | Update a related item by id for requestedDesigns.
[**TeamMembersIdRequestedDesignsGet**](TeamMemberApi.md#teammembersidrequesteddesignsget) | **GET** /TeamMembers/{id}/requestedDesigns | Queries requestedDesigns of TeamMember.
[**TeamMembersIdRequestedDesignsPost**](TeamMemberApi.md#teammembersidrequesteddesignspost) | **POST** /TeamMembers/{id}/requestedDesigns | Creates a new instance in requestedDesigns of this model.
[**TeamMembersIdReviewedDesignsCountGet**](TeamMemberApi.md#teammembersidrevieweddesignscountget) | **GET** /TeamMembers/{id}/reviewedDesigns/count | Counts reviewedDesigns of TeamMember.
[**TeamMembersIdReviewedDesignsDelete**](TeamMemberApi.md#teammembersidrevieweddesignsdelete) | **DELETE** /TeamMembers/{id}/reviewedDesigns | Deletes all reviewedDesigns of this model.
[**TeamMembersIdReviewedDesignsFkDelete**](TeamMemberApi.md#teammembersidrevieweddesignsfkdelete) | **DELETE** /TeamMembers/{id}/reviewedDesigns/{fk} | Delete a related item by id for reviewedDesigns.
[**TeamMembersIdReviewedDesignsFkGet**](TeamMemberApi.md#teammembersidrevieweddesignsfkget) | **GET** /TeamMembers/{id}/reviewedDesigns/{fk} | Find a related item by id for reviewedDesigns.
[**TeamMembersIdReviewedDesignsFkPut**](TeamMemberApi.md#teammembersidrevieweddesignsfkput) | **PUT** /TeamMembers/{id}/reviewedDesigns/{fk} | Update a related item by id for reviewedDesigns.
[**TeamMembersIdReviewedDesignsGet**](TeamMemberApi.md#teammembersidrevieweddesignsget) | **GET** /TeamMembers/{id}/reviewedDesigns | Queries reviewedDesigns of TeamMember.
[**TeamMembersIdReviewedDesignsPost**](TeamMemberApi.md#teammembersidrevieweddesignspost) | **POST** /TeamMembers/{id}/reviewedDesigns | Creates a new instance in reviewedDesigns of this model.
[**TeamMembersIdSharedDesignsCountGet**](TeamMemberApi.md#teammembersidshareddesignscountget) | **GET** /TeamMembers/{id}/sharedDesigns/count | Counts sharedDesigns of TeamMember.
[**TeamMembersIdSharedDesignsDelete**](TeamMemberApi.md#teammembersidshareddesignsdelete) | **DELETE** /TeamMembers/{id}/sharedDesigns | Deletes all sharedDesigns of this model.
[**TeamMembersIdSharedDesignsFkDelete**](TeamMemberApi.md#teammembersidshareddesignsfkdelete) | **DELETE** /TeamMembers/{id}/sharedDesigns/{fk} | Delete a related item by id for sharedDesigns.
[**TeamMembersIdSharedDesignsFkGet**](TeamMemberApi.md#teammembersidshareddesignsfkget) | **GET** /TeamMembers/{id}/sharedDesigns/{fk} | Find a related item by id for sharedDesigns.
[**TeamMembersIdSharedDesignsFkPut**](TeamMemberApi.md#teammembersidshareddesignsfkput) | **PUT** /TeamMembers/{id}/sharedDesigns/{fk} | Update a related item by id for sharedDesigns.
[**TeamMembersIdSharedDesignsGet**](TeamMemberApi.md#teammembersidshareddesignsget) | **GET** /TeamMembers/{id}/sharedDesigns | Queries sharedDesigns of TeamMember.
[**TeamMembersIdSharedDesignsPost**](TeamMemberApi.md#teammembersidshareddesignspost) | **POST** /TeamMembers/{id}/sharedDesigns | Creates a new instance in sharedDesigns of this model.
[**TeamMembersIdSharedDesignsRelFkDelete**](TeamMemberApi.md#teammembersidshareddesignsrelfkdelete) | **DELETE** /TeamMembers/{id}/sharedDesigns/rel/{fk} | Remove the sharedDesigns relation to an item by id.
[**TeamMembersIdSharedDesignsRelFkHead**](TeamMemberApi.md#teammembersidshareddesignsrelfkhead) | **HEAD** /TeamMembers/{id}/sharedDesigns/rel/{fk} | Check the existence of sharedDesigns relation to an item by id.
[**TeamMembersIdSharedDesignsRelFkPut**](TeamMemberApi.md#teammembersidshareddesignsrelfkput) | **PUT** /TeamMembers/{id}/sharedDesigns/rel/{fk} | Add a related item by id for sharedDesigns.
[**TeamMembersIdTargetModelTargetIdInviteInviteePost**](TeamMemberApi.md#teammembersidtargetmodeltargetidinviteinviteepost) | **POST** /TeamMembers/{id}/{targetModel}/{targetId}/invite/{invitee} | Invite somebody to join a team, portal or other targets
[**TeamMembersIdTargetModelTargetIdInvitePost**](TeamMemberApi.md#teammembersidtargetmodeltargetidinvitepost) | **POST** /TeamMembers/{id}/{targetModel}/{targetId}/invite | Invite a group of people to join a team, portal or other targets
[**TeamMembersIdTeamBillingAvailablePlansGet**](TeamMemberApi.md#teammembersidteambillingavailableplansget) | **GET** /TeamMembers/{id}/team/billing/availablePlans | Get Available Plans
[**TeamMembersIdTeamBillingBankAccountDelete**](TeamMemberApi.md#teammembersidteambillingbankaccountdelete) | **DELETE** /TeamMembers/{id}/team/billing/bankAccount | Delete Team Billing BankAccount
[**TeamMembersIdTeamBillingBankAccountPost**](TeamMemberApi.md#teammembersidteambillingbankaccountpost) | **POST** /TeamMembers/{id}/team/billing/bankAccount | Create Team Billing BankAccount
[**TeamMembersIdTeamBillingBankAccountPut**](TeamMemberApi.md#teammembersidteambillingbankaccountput) | **PUT** /TeamMembers/{id}/team/billing/bankAccount | Update Team Billing BankAccount
[**TeamMembersIdTeamBillingBankAccountVerifyPost**](TeamMemberApi.md#teammembersidteambillingbankaccountverifypost) | **POST** /TeamMembers/{id}/team/billing/bankAccount/verify | Create Team Billing BankAccount
[**TeamMembersIdTeamBillingCachedGet**](TeamMemberApi.md#teammembersidteambillingcachedget) | **GET** /TeamMembers/{id}/team/billing/cached | Get Cached version of Team Billing
[**TeamMembersIdTeamBillingCardDelete**](TeamMemberApi.md#teammembersidteambillingcarddelete) | **DELETE** /TeamMembers/{id}/team/billing/card | Delete Team Billing Card
[**TeamMembersIdTeamBillingCardPost**](TeamMemberApi.md#teammembersidteambillingcardpost) | **POST** /TeamMembers/{id}/team/billing/card | Create Team Billing Card
[**TeamMembersIdTeamBillingCardPut**](TeamMemberApi.md#teammembersidteambillingcardput) | **PUT** /TeamMembers/{id}/team/billing/card | Update Team Billing Card
[**TeamMembersIdTeamBillingInvoicesFkPost**](TeamMemberApi.md#teammembersidteambillinginvoicesfkpost) | **POST** /TeamMembers/{id}/team/billing/invoices/{fk} | Pay Team Billing Invoice
[**TeamMembersIdTeamBillingInvoicesGet**](TeamMemberApi.md#teammembersidteambillinginvoicesget) | **GET** /TeamMembers/{id}/team/billing/invoices | List Team Billing Invoices
[**TeamMembersIdTeamBillingInvoicesUpcomingGet**](TeamMemberApi.md#teammembersidteambillinginvoicesupcomingget) | **GET** /TeamMembers/{id}/team/billing/invoices/upcoming | List Upcoming Team Billing Invoices
[**TeamMembersIdTeamBillingLimitLimitIncreasePost**](TeamMemberApi.md#teammembersidteambillinglimitlimitincreasepost) | **POST** /TeamMembers/{id}/team/billing/limit/{limit}/increase | Increase Team Billing Limit by Limit
[**TeamMembersIdTeamBillingLimitLimitIncreaseValueGet**](TeamMemberApi.md#teammembersidteambillinglimitlimitincreasevalueget) | **GET** /TeamMembers/{id}/team/billing/limit/{limit}/increase/{value} | Check if Team Billing Limit can be increased by Limit
[**TeamMembersIdTeamBillingPut**](TeamMemberApi.md#teammembersidteambillingput) | **PUT** /TeamMembers/{id}/team/billing | Update Team Billing
[**TeamMembersIdTeamBillingSourceDelete**](TeamMemberApi.md#teammembersidteambillingsourcedelete) | **DELETE** /TeamMembers/{id}/team/billing/source | Delete Team Billing Source
[**TeamMembersIdTeamBillingSourcePost**](TeamMemberApi.md#teammembersidteambillingsourcepost) | **POST** /TeamMembers/{id}/team/billing/source | Create Team Billing Source
[**TeamMembersIdTeamBillingSourcePut**](TeamMemberApi.md#teammembersidteambillingsourceput) | **PUT** /TeamMembers/{id}/team/billing/source | Update Team Billing Source
[**TeamMembersIdTeamBillingSubscriptionPlanPut**](TeamMemberApi.md#teammembersidteambillingsubscriptionplanput) | **PUT** /TeamMembers/{id}/team/billing/subscription/plan | Update Team Billing Subscription Plan
[**TeamMembersIdTeamBillingTaxEvidenceGet**](TeamMemberApi.md#teammembersidteambillingtaxevidenceget) | **GET** /TeamMembers/{id}/team/billing/taxEvidence | Get Team Billing Tax Evidence
[**TeamMembersIdTeamBillingUncachedGet**](TeamMemberApi.md#teammembersidteambillinguncachedget) | **GET** /TeamMembers/{id}/team/billing/uncached | Get Team Billing
[**TeamMembersIdTeamBrandDelete**](TeamMemberApi.md#teammembersidteambranddelete) | **DELETE** /TeamMembers/{id}/team/brand | Deletes brand of this model.
[**TeamMembersIdTeamBrandGet**](TeamMemberApi.md#teammembersidteambrandget) | **GET** /TeamMembers/{id}/team/brand | Fetches hasOne relation brand.
[**TeamMembersIdTeamBrandPost**](TeamMemberApi.md#teammembersidteambrandpost) | **POST** /TeamMembers/{id}/team/brand | Creates a new instance in brand of this model.
[**TeamMembersIdTeamBrandPut**](TeamMemberApi.md#teammembersidteambrandput) | **PUT** /TeamMembers/{id}/team/brand | Update brand of this model.
[**TeamMembersIdTeamBuilderConfigsCountGet**](TeamMemberApi.md#teammembersidteambuilderconfigscountget) | **GET** /TeamMembers/{id}/team/builderConfigs/count | Counts builderConfigs of Team.
[**TeamMembersIdTeamBuilderConfigsDefaultGet**](TeamMemberApi.md#teammembersidteambuilderconfigsdefaultget) | **GET** /TeamMembers/{id}/team/builderConfigs/default | Get default Team Builder Config
[**TeamMembersIdTeamBuilderConfigsDefaultProductSizeMaterialGet**](TeamMemberApi.md#teammembersidteambuilderconfigsdefaultproductsizematerialget) | **GET** /TeamMembers/{id}/team/builderConfigs/default/productSizeMaterial | Get default Team Builder Config Product Size Materials
[**TeamMembersIdTeamBuilderConfigsDelete**](TeamMemberApi.md#teammembersidteambuilderconfigsdelete) | **DELETE** /TeamMembers/{id}/team/builderConfigs | Deletes all builderConfigs of this model.
[**TeamMembersIdTeamBuilderConfigsFkDelete**](TeamMemberApi.md#teammembersidteambuilderconfigsfkdelete) | **DELETE** /TeamMembers/{id}/team/builderConfigs/{fk} | Delete a related item by id for builderConfigs.
[**TeamMembersIdTeamBuilderConfigsFkGet**](TeamMemberApi.md#teammembersidteambuilderconfigsfkget) | **GET** /TeamMembers/{id}/team/builderConfigs/{fk} | Find a related item by id for builderConfigs.
[**TeamMembersIdTeamBuilderConfigsFkLogoPut**](TeamMemberApi.md#teammembersidteambuilderconfigsfklogoput) | **PUT** /TeamMembers/{id}/team/builderConfigs/{fk}/logo | Change Builder Config logo
[**TeamMembersIdTeamBuilderConfigsFkPut**](TeamMemberApi.md#teammembersidteambuilderconfigsfkput) | **PUT** /TeamMembers/{id}/team/builderConfigs/{fk} | Update a related item by id for builderConfigs.
[**TeamMembersIdTeamBuilderConfigsFkWatermarkPut**](TeamMemberApi.md#teammembersidteambuilderconfigsfkwatermarkput) | **PUT** /TeamMembers/{id}/team/builderConfigs/{fk}/watermark | Change Builder Config watermark
[**TeamMembersIdTeamBuilderConfigsGet**](TeamMemberApi.md#teammembersidteambuilderconfigsget) | **GET** /TeamMembers/{id}/team/builderConfigs | Queries builderConfigs of Team.
[**TeamMembersIdTeamBuilderConfigsPost**](TeamMemberApi.md#teammembersidteambuilderconfigspost) | **POST** /TeamMembers/{id}/team/builderConfigs | Creates a new instance in builderConfigs of this model.
[**TeamMembersIdTeamDataRecordGet**](TeamMemberApi.md#teammembersidteamdatarecordget) | **GET** /TeamMembers/{id}/teamData/record | Get TeamData Record
[**TeamMembersIdTeamDataRecordPost**](TeamMemberApi.md#teammembersidteamdatarecordpost) | **POST** /TeamMembers/{id}/teamData/record | Create TeamData Record
[**TeamMembersIdTeamDataRecordPut**](TeamMemberApi.md#teammembersidteamdatarecordput) | **PUT** /TeamMembers/{id}/teamData/record | Update TeamData Record
[**TeamMembersIdTeamDataSourcesCountGet**](TeamMemberApi.md#teammembersidteamdatasourcescountget) | **GET** /TeamMembers/{id}/team/dataSources/count | Counts dataSources of Team.
[**TeamMembersIdTeamDataSourcesDelete**](TeamMemberApi.md#teammembersidteamdatasourcesdelete) | **DELETE** /TeamMembers/{id}/team/dataSources | Deletes all dataSources of this model.
[**TeamMembersIdTeamDataSourcesFkDelete**](TeamMemberApi.md#teammembersidteamdatasourcesfkdelete) | **DELETE** /TeamMembers/{id}/team/dataSources/{fk} | Delete a related item by id for dataSources.
[**TeamMembersIdTeamDataSourcesFkGet**](TeamMemberApi.md#teammembersidteamdatasourcesfkget) | **GET** /TeamMembers/{id}/team/dataSources/{fk} | Find a related item by id for dataSources.
[**TeamMembersIdTeamDataSourcesFkPut**](TeamMemberApi.md#teammembersidteamdatasourcesfkput) | **PUT** /TeamMembers/{id}/team/dataSources/{fk} | Update a related item by id for dataSources.
[**TeamMembersIdTeamDataSourcesGet**](TeamMemberApi.md#teammembersidteamdatasourcesget) | **GET** /TeamMembers/{id}/team/dataSources | Queries dataSources of Team.
[**TeamMembersIdTeamDataSourcesPost**](TeamMemberApi.md#teammembersidteamdatasourcespost) | **POST** /TeamMembers/{id}/team/dataSources | Creates a new instance in dataSources of this model.
[**TeamMembersIdTeamDynamicDatasCountGet**](TeamMemberApi.md#teammembersidteamdynamicdatascountget) | **GET** /TeamMembers/{id}/team/dynamicDatas/count | Counts dynamicDatas of Team.
[**TeamMembersIdTeamDynamicDatasDelete**](TeamMemberApi.md#teammembersidteamdynamicdatasdelete) | **DELETE** /TeamMembers/{id}/team/dynamicDatas | Deletes all dynamicDatas of this model.
[**TeamMembersIdTeamDynamicDatasFkDelete**](TeamMemberApi.md#teammembersidteamdynamicdatasfkdelete) | **DELETE** /TeamMembers/{id}/team/dynamicDatas/{fk} | Delete a related item by id for dynamicDatas.
[**TeamMembersIdTeamDynamicDatasFkGet**](TeamMemberApi.md#teammembersidteamdynamicdatasfkget) | **GET** /TeamMembers/{id}/team/dynamicDatas/{fk} | Find a related item by id for dynamicDatas.
[**TeamMembersIdTeamDynamicDatasFkPut**](TeamMemberApi.md#teammembersidteamdynamicdatasfkput) | **PUT** /TeamMembers/{id}/team/dynamicDatas/{fk} | Update a related item by id for dynamicDatas.
[**TeamMembersIdTeamDynamicDatasGet**](TeamMemberApi.md#teammembersidteamdynamicdatasget) | **GET** /TeamMembers/{id}/team/dynamicDatas | Queries dynamicDatas of Team.
[**TeamMembersIdTeamDynamicDatasPost**](TeamMemberApi.md#teammembersidteamdynamicdataspost) | **POST** /TeamMembers/{id}/team/dynamicDatas | Creates a new instance in dynamicDatas of this model.
[**TeamMembersIdTeamGet**](TeamMemberApi.md#teammembersidteamget) | **GET** /TeamMembers/{id}/team | Fetches belongsTo relation team.
[**TeamMembersIdTeamImageFoldersCountGet**](TeamMemberApi.md#teammembersidteamimagefolderscountget) | **GET** /TeamMembers/{id}/team/imageFolders/count | Counts imageFolders of Team.
[**TeamMembersIdTeamImageFoldersDelete**](TeamMemberApi.md#teammembersidteamimagefoldersdelete) | **DELETE** /TeamMembers/{id}/team/imageFolders | Deletes all imageFolders of this model.
[**TeamMembersIdTeamImageFoldersFkDelete**](TeamMemberApi.md#teammembersidteamimagefoldersfkdelete) | **DELETE** /TeamMembers/{id}/team/imageFolders/{fk} | Delete a related item by id for imageFolders.
[**TeamMembersIdTeamImageFoldersFkGet**](TeamMemberApi.md#teammembersidteamimagefoldersfkget) | **GET** /TeamMembers/{id}/team/imageFolders/{fk} | Find a related item by id for imageFolders.
[**TeamMembersIdTeamImageFoldersFkPut**](TeamMemberApi.md#teammembersidteamimagefoldersfkput) | **PUT** /TeamMembers/{id}/team/imageFolders/{fk} | Update a related item by id for imageFolders.
[**TeamMembersIdTeamImageFoldersGet**](TeamMemberApi.md#teammembersidteamimagefoldersget) | **GET** /TeamMembers/{id}/team/imageFolders | Queries imageFolders of Team.
[**TeamMembersIdTeamImageFoldersPost**](TeamMemberApi.md#teammembersidteamimagefolderspost) | **POST** /TeamMembers/{id}/team/imageFolders | Creates a new instance in imageFolders of this model.
[**TeamMembersIdTeamImagesCountGet**](TeamMemberApi.md#teammembersidteamimagescountget) | **GET** /TeamMembers/{id}/team/images/count | Counts images of Team.
[**TeamMembersIdTeamImagesDelete**](TeamMemberApi.md#teammembersidteamimagesdelete) | **DELETE** /TeamMembers/{id}/team/images | Deletes all images of this model.
[**TeamMembersIdTeamImagesFkDelete**](TeamMemberApi.md#teammembersidteamimagesfkdelete) | **DELETE** /TeamMembers/{id}/team/images/{fk} | Delete a related item by id for images.
[**TeamMembersIdTeamImagesFkGet**](TeamMemberApi.md#teammembersidteamimagesfkget) | **GET** /TeamMembers/{id}/team/images/{fk} | Find a related item by id for images.
[**TeamMembersIdTeamImagesFkPut**](TeamMemberApi.md#teammembersidteamimagesfkput) | **PUT** /TeamMembers/{id}/team/images/{fk} | Update a related item by id for images.
[**TeamMembersIdTeamImagesGet**](TeamMemberApi.md#teammembersidteamimagesget) | **GET** /TeamMembers/{id}/team/images | Queries images of Team.
[**TeamMembersIdTeamImagesPost**](TeamMemberApi.md#teammembersidteamimagespost) | **POST** /TeamMembers/{id}/team/images | Creates a new instance in images of this model.
[**TeamMembersIdTeamLogoPut**](TeamMemberApi.md#teammembersidteamlogoput) | **PUT** /TeamMembers/{id}/team/logo | Change Team logo
[**TeamMembersIdTeamMembersCountGet**](TeamMemberApi.md#teammembersidteammemberscountget) | **GET** /TeamMembers/{id}/team/members/count | Counts members of Team.
[**TeamMembersIdTeamMembersDelete**](TeamMemberApi.md#teammembersidteammembersdelete) | **DELETE** /TeamMembers/{id}/team/members | Deletes all members of this model.
[**TeamMembersIdTeamMembersFkDelete**](TeamMemberApi.md#teammembersidteammembersfkdelete) | **DELETE** /TeamMembers/{id}/team/members/{fk} | Delete a related item by id for members.
[**TeamMembersIdTeamMembersFkGet**](TeamMemberApi.md#teammembersidteammembersfkget) | **GET** /TeamMembers/{id}/team/members/{fk} | Find a related item by id for members.
[**TeamMembersIdTeamMembersFkPut**](TeamMemberApi.md#teammembersidteammembersfkput) | **PUT** /TeamMembers/{id}/team/members/{fk} | Update a related item by id for members.
[**TeamMembersIdTeamMembersGet**](TeamMemberApi.md#teammembersidteammembersget) | **GET** /TeamMembers/{id}/team/members | Queries members of Team.
[**TeamMembersIdTeamMembersPost**](TeamMemberApi.md#teammembersidteammemberspost) | **POST** /TeamMembers/{id}/team/members | Creates a new instance in members of this model.
[**TeamMembersIdTeamMembersRelFkDelete**](TeamMemberApi.md#teammembersidteammembersrelfkdelete) | **DELETE** /TeamMembers/{id}/team/members/rel/{fk} | Remove the members relation to an item by id.
[**TeamMembersIdTeamMembersRelFkHead**](TeamMemberApi.md#teammembersidteammembersrelfkhead) | **HEAD** /TeamMembers/{id}/team/members/rel/{fk} | Check the existence of members relation to an item by id.
[**TeamMembersIdTeamMembersRelFkPut**](TeamMemberApi.md#teammembersidteammembersrelfkput) | **PUT** /TeamMembers/{id}/team/members/rel/{fk} | Add a related item by id for members.
[**TeamMembersIdTeamPermissionDelete**](TeamMemberApi.md#teammembersidteampermissiondelete) | **DELETE** /TeamMembers/{id}/team/permission | Deletes permission of this model.
[**TeamMembersIdTeamPermissionGet**](TeamMemberApi.md#teammembersidteampermissionget) | **GET** /TeamMembers/{id}/team/permission | Fetches hasOne relation permission.
[**TeamMembersIdTeamPermissionPost**](TeamMemberApi.md#teammembersidteampermissionpost) | **POST** /TeamMembers/{id}/team/permission | Creates a new instance in permission of this model.
[**TeamMembersIdTeamPermissionPut**](TeamMemberApi.md#teammembersidteampermissionput) | **PUT** /TeamMembers/{id}/team/permission | Update permission of this model.
[**TeamMembersIdTeamPortalsCountGet**](TeamMemberApi.md#teammembersidteamportalscountget) | **GET** /TeamMembers/{id}/team/portals/count | Counts portals of Team.
[**TeamMembersIdTeamPortalsDelete**](TeamMemberApi.md#teammembersidteamportalsdelete) | **DELETE** /TeamMembers/{id}/team/portals | Deletes all portals of this model.
[**TeamMembersIdTeamPortalsFkDelete**](TeamMemberApi.md#teammembersidteamportalsfkdelete) | **DELETE** /TeamMembers/{id}/team/portals/{fk} | Delete a related item by id for portals.
[**TeamMembersIdTeamPortalsFkGet**](TeamMemberApi.md#teammembersidteamportalsfkget) | **GET** /TeamMembers/{id}/team/portals/{fk} | Find a related item by id for portals.
[**TeamMembersIdTeamPortalsFkPut**](TeamMemberApi.md#teammembersidteamportalsfkput) | **PUT** /TeamMembers/{id}/team/portals/{fk} | Update a related item by id for portals.
[**TeamMembersIdTeamPortalsGet**](TeamMemberApi.md#teammembersidteamportalsget) | **GET** /TeamMembers/{id}/team/portals | Queries portals of Team.
[**TeamMembersIdTeamPortalsPost**](TeamMemberApi.md#teammembersidteamportalspost) | **POST** /TeamMembers/{id}/team/portals | Creates a new instance in portals of this model.
[**TeamMembersIdTeamProductMaterialsCountGet**](TeamMemberApi.md#teammembersidteamproductmaterialscountget) | **GET** /TeamMembers/{id}/team/productMaterials/count | Counts productMaterials of Team.
[**TeamMembersIdTeamProductMaterialsDelete**](TeamMemberApi.md#teammembersidteamproductmaterialsdelete) | **DELETE** /TeamMembers/{id}/team/productMaterials | Deletes all productMaterials of this model.
[**TeamMembersIdTeamProductMaterialsFkDelete**](TeamMemberApi.md#teammembersidteamproductmaterialsfkdelete) | **DELETE** /TeamMembers/{id}/team/productMaterials/{fk} | Delete a related item by id for productMaterials.
[**TeamMembersIdTeamProductMaterialsFkGet**](TeamMemberApi.md#teammembersidteamproductmaterialsfkget) | **GET** /TeamMembers/{id}/team/productMaterials/{fk} | Find a related item by id for productMaterials.
[**TeamMembersIdTeamProductMaterialsFkPut**](TeamMemberApi.md#teammembersidteamproductmaterialsfkput) | **PUT** /TeamMembers/{id}/team/productMaterials/{fk} | Update a related item by id for productMaterials.
[**TeamMembersIdTeamProductMaterialsGet**](TeamMemberApi.md#teammembersidteamproductmaterialsget) | **GET** /TeamMembers/{id}/team/productMaterials | Queries productMaterials of Team.
[**TeamMembersIdTeamProductMaterialsPost**](TeamMemberApi.md#teammembersidteamproductmaterialspost) | **POST** /TeamMembers/{id}/team/productMaterials | Creates a new instance in productMaterials of this model.
[**TeamMembersIdTeamProductPdfColorProfilesAvailableGet**](TeamMemberApi.md#teammembersidteamproductpdfcolorprofilesavailableget) | **GET** /TeamMembers/{id}/team/productPdfColorProfiles/available | Find all available PdfColorProfile
[**TeamMembersIdTeamProductPdfColorProfilesCountGet**](TeamMemberApi.md#teammembersidteamproductpdfcolorprofilescountget) | **GET** /TeamMembers/{id}/team/productPdfColorProfiles/count | Counts productPdfColorProfiles of Team.
[**TeamMembersIdTeamProductPdfColorProfilesDelete**](TeamMemberApi.md#teammembersidteamproductpdfcolorprofilesdelete) | **DELETE** /TeamMembers/{id}/team/productPdfColorProfiles | Deletes all productPdfColorProfiles of this model.
[**TeamMembersIdTeamProductPdfColorProfilesFkDelete**](TeamMemberApi.md#teammembersidteamproductpdfcolorprofilesfkdelete) | **DELETE** /TeamMembers/{id}/team/productPdfColorProfiles/{fk} | Delete a related item by id for productPdfColorProfiles.
[**TeamMembersIdTeamProductPdfColorProfilesFkGet**](TeamMemberApi.md#teammembersidteamproductpdfcolorprofilesfkget) | **GET** /TeamMembers/{id}/team/productPdfColorProfiles/{fk} | Find a related item by id for productPdfColorProfiles.
[**TeamMembersIdTeamProductPdfColorProfilesFkPut**](TeamMemberApi.md#teammembersidteamproductpdfcolorprofilesfkput) | **PUT** /TeamMembers/{id}/team/productPdfColorProfiles/{fk} | Update a related item by id for productPdfColorProfiles.
[**TeamMembersIdTeamProductPdfColorProfilesGet**](TeamMemberApi.md#teammembersidteamproductpdfcolorprofilesget) | **GET** /TeamMembers/{id}/team/productPdfColorProfiles | Queries productPdfColorProfiles of Team.
[**TeamMembersIdTeamProductPdfColorProfilesUploadPost**](TeamMemberApi.md#teammembersidteamproductpdfcolorprofilesuploadpost) | **POST** /TeamMembers/{id}/team/productPdfColorProfiles/upload | Upload ICC PDF Color Profile for this Team
[**TeamMembersIdTeamProductSizeMaterialsCountGet**](TeamMemberApi.md#teammembersidteamproductsizematerialscountget) | **GET** /TeamMembers/{id}/team/productSizeMaterials/count | Counts productSizeMaterials of Team.
[**TeamMembersIdTeamProductSizeMaterialsDelete**](TeamMemberApi.md#teammembersidteamproductsizematerialsdelete) | **DELETE** /TeamMembers/{id}/team/productSizeMaterials | Deletes all productSizeMaterials of this model.
[**TeamMembersIdTeamProductSizeMaterialsFkDelete**](TeamMemberApi.md#teammembersidteamproductsizematerialsfkdelete) | **DELETE** /TeamMembers/{id}/team/productSizeMaterials/{fk} | Delete a related item by id for productSizeMaterials.
[**TeamMembersIdTeamProductSizeMaterialsFkGet**](TeamMemberApi.md#teammembersidteamproductsizematerialsfkget) | **GET** /TeamMembers/{id}/team/productSizeMaterials/{fk} | Find a related item by id for productSizeMaterials.
[**TeamMembersIdTeamProductSizeMaterialsFkPut**](TeamMemberApi.md#teammembersidteamproductsizematerialsfkput) | **PUT** /TeamMembers/{id}/team/productSizeMaterials/{fk} | Update a related item by id for productSizeMaterials.
[**TeamMembersIdTeamProductSizeMaterialsGet**](TeamMemberApi.md#teammembersidteamproductsizematerialsget) | **GET** /TeamMembers/{id}/team/productSizeMaterials | Queries productSizeMaterials of Team.
[**TeamMembersIdTeamProductSizeMaterialsPost**](TeamMemberApi.md#teammembersidteamproductsizematerialspost) | **POST** /TeamMembers/{id}/team/productSizeMaterials | Creates a new instance in productSizeMaterials of this model.
[**TeamMembersIdTeamTeamDataGet**](TeamMemberApi.md#teammembersidteamteamdataget) | **GET** /TeamMembers/{id}/team/teamData | Fetches belongsTo relation teamData.
[**TeamMembersIdTeamTeamMembersCountGet**](TeamMemberApi.md#teammembersidteamteammemberscountget) | **GET** /TeamMembers/{id}/team/teamMembers/count | Counts teamMembers of Team.
[**TeamMembersIdTeamTeamMembersDelete**](TeamMemberApi.md#teammembersidteamteammembersdelete) | **DELETE** /TeamMembers/{id}/team/teamMembers | Deletes all teamMembers of this model.
[**TeamMembersIdTeamTeamMembersFkDelete**](TeamMemberApi.md#teammembersidteamteammembersfkdelete) | **DELETE** /TeamMembers/{id}/team/teamMembers/{fk} | Delete a related item by id for teamMembers.
[**TeamMembersIdTeamTeamMembersFkGet**](TeamMemberApi.md#teammembersidteamteammembersfkget) | **GET** /TeamMembers/{id}/team/teamMembers/{fk} | Find a related item by id for teamMembers.
[**TeamMembersIdTeamTeamMembersFkPut**](TeamMemberApi.md#teammembersidteamteammembersfkput) | **PUT** /TeamMembers/{id}/team/teamMembers/{fk} | Update a related item by id for teamMembers.
[**TeamMembersIdTeamTeamMembersGet**](TeamMemberApi.md#teammembersidteamteammembersget) | **GET** /TeamMembers/{id}/team/teamMembers | Queries teamMembers of Team.
[**TeamMembersIdTeamTeamMembersPost**](TeamMemberApi.md#teammembersidteamteammemberspost) | **POST** /TeamMembers/{id}/team/teamMembers | Creates a new instance in teamMembers of this model.
[**TeamMembersIdTeamTemplateFoldersCountGet**](TeamMemberApi.md#teammembersidteamtemplatefolderscountget) | **GET** /TeamMembers/{id}/team/templateFolders/count | Counts templateFolders of Team.
[**TeamMembersIdTeamTemplateFoldersDelete**](TeamMemberApi.md#teammembersidteamtemplatefoldersdelete) | **DELETE** /TeamMembers/{id}/team/templateFolders | Deletes all templateFolders of this model.
[**TeamMembersIdTeamTemplateFoldersFkDelete**](TeamMemberApi.md#teammembersidteamtemplatefoldersfkdelete) | **DELETE** /TeamMembers/{id}/team/templateFolders/{fk} | Delete a related item by id for templateFolders.
[**TeamMembersIdTeamTemplateFoldersFkGet**](TeamMemberApi.md#teammembersidteamtemplatefoldersfkget) | **GET** /TeamMembers/{id}/team/templateFolders/{fk} | Find a related item by id for templateFolders.
[**TeamMembersIdTeamTemplateFoldersFkPut**](TeamMemberApi.md#teammembersidteamtemplatefoldersfkput) | **PUT** /TeamMembers/{id}/team/templateFolders/{fk} | Update a related item by id for templateFolders.
[**TeamMembersIdTeamTemplateFoldersGet**](TeamMemberApi.md#teammembersidteamtemplatefoldersget) | **GET** /TeamMembers/{id}/team/templateFolders | Queries templateFolders of Team.
[**TeamMembersIdTeamTemplateFoldersPost**](TeamMemberApi.md#teammembersidteamtemplatefolderspost) | **POST** /TeamMembers/{id}/team/templateFolders | Creates a new instance in templateFolders of this model.
[**TeamMembersIdTeamTemplatesCountGet**](TeamMemberApi.md#teammembersidteamtemplatescountget) | **GET** /TeamMembers/{id}/team/templates/count | Counts templates of Team.
[**TeamMembersIdTeamTemplatesDelete**](TeamMemberApi.md#teammembersidteamtemplatesdelete) | **DELETE** /TeamMembers/{id}/team/templates | Deletes all templates of this model.
[**TeamMembersIdTeamTemplatesFkDelete**](TeamMemberApi.md#teammembersidteamtemplatesfkdelete) | **DELETE** /TeamMembers/{id}/team/templates/{fk} | Delete a related item by id for templates.
[**TeamMembersIdTeamTemplatesFkGet**](TeamMemberApi.md#teammembersidteamtemplatesfkget) | **GET** /TeamMembers/{id}/team/templates/{fk} | Find a related item by id for templates.
[**TeamMembersIdTeamTemplatesFkPut**](TeamMemberApi.md#teammembersidteamtemplatesfkput) | **PUT** /TeamMembers/{id}/team/templates/{fk} | Update a related item by id for templates.
[**TeamMembersIdTeamTemplatesFkUrlReviewGet**](TeamMemberApi.md#teammembersidteamtemplatesfkurlreviewget) | **GET** /TeamMembers/{id}/team/templates/{fk}/url/review | Get URL to review a Team Template
[**TeamMembersIdTeamTemplatesGet**](TeamMemberApi.md#teammembersidteamtemplatesget) | **GET** /TeamMembers/{id}/team/templates | Queries templates of Team.
[**TeamMembersIdTeamTemplatesPost**](TeamMemberApi.md#teammembersidteamtemplatespost) | **POST** /TeamMembers/{id}/team/templates | Creates a new instance in templates of this model.
[**TeamMembersIdTeamTemplatesWithDesignsGet**](TeamMemberApi.md#teammembersidteamtemplateswithdesignsget) | **GET** /TeamMembers/{id}/team/templatesWithDesigns | List Templates with Designs for the Team of TeamMember
[**TeamMembersIdTeamWorkflowsCountGet**](TeamMemberApi.md#teammembersidteamworkflowscountget) | **GET** /TeamMembers/{id}/team/workflows/count | Counts workflows of Team.
[**TeamMembersIdTeamWorkflowsDelete**](TeamMemberApi.md#teammembersidteamworkflowsdelete) | **DELETE** /TeamMembers/{id}/team/workflows | Deletes all workflows of this model.
[**TeamMembersIdTeamWorkflowsFkDelete**](TeamMemberApi.md#teammembersidteamworkflowsfkdelete) | **DELETE** /TeamMembers/{id}/team/workflows/{fk} | Delete a related item by id for workflows.
[**TeamMembersIdTeamWorkflowsFkGet**](TeamMemberApi.md#teammembersidteamworkflowsfkget) | **GET** /TeamMembers/{id}/team/workflows/{fk} | Find a related item by id for workflows.
[**TeamMembersIdTeamWorkflowsFkPut**](TeamMemberApi.md#teammembersidteamworkflowsfkput) | **PUT** /TeamMembers/{id}/team/workflows/{fk} | Update a related item by id for workflows.
[**TeamMembersIdTeamWorkflowsGet**](TeamMemberApi.md#teammembersidteamworkflowsget) | **GET** /TeamMembers/{id}/team/workflows | Queries workflows of Team.
[**TeamMembersIdTeamWorkflowsPost**](TeamMemberApi.md#teammembersidteamworkflowspost) | **POST** /TeamMembers/{id}/team/workflows | Creates a new instance in workflows of this model.
[**TeamMembersIdTemplatesCountGet**](TeamMemberApi.md#teammembersidtemplatescountget) | **GET** /TeamMembers/{id}/templates/count | Counts templates of TeamMember.
[**TeamMembersIdTemplatesDelete**](TeamMemberApi.md#teammembersidtemplatesdelete) | **DELETE** /TeamMembers/{id}/templates | Deletes all templates of this model.
[**TeamMembersIdTemplatesFkDelete**](TeamMemberApi.md#teammembersidtemplatesfkdelete) | **DELETE** /TeamMembers/{id}/templates/{fk} | Delete a related item by id for templates.
[**TeamMembersIdTemplatesFkFlashvarsGet**](TeamMemberApi.md#teammembersidtemplatesfkflashvarsget) | **GET** /TeamMembers/{id}/templates/{fk}/flashvars | Find Template FlashVars by id
[**TeamMembersIdTemplatesFkGet**](TeamMemberApi.md#teammembersidtemplatesfkget) | **GET** /TeamMembers/{id}/templates/{fk} | Find a related item by id for templates.
[**TeamMembersIdTemplatesFkPut**](TeamMemberApi.md#teammembersidtemplatesfkput) | **PUT** /TeamMembers/{id}/templates/{fk} | Update a related item by id for templates.
[**TeamMembersIdTemplatesGet**](TeamMemberApi.md#teammembersidtemplatesget) | **GET** /TeamMembers/{id}/templates | Queries templates of TeamMember.
[**TeamMembersIdTemplatesPost**](TeamMemberApi.md#teammembersidtemplatespost) | **POST** /TeamMembers/{id}/templates | Creates a new instance in templates of this model.
[**TeamMembersIdTemplatesRelFkDelete**](TeamMemberApi.md#teammembersidtemplatesrelfkdelete) | **DELETE** /TeamMembers/{id}/templates/rel/{fk} | Remove the templates relation to an item by id.
[**TeamMembersIdTemplatesRelFkHead**](TeamMemberApi.md#teammembersidtemplatesrelfkhead) | **HEAD** /TeamMembers/{id}/templates/rel/{fk} | Check the existence of templates relation to an item by id.
[**TeamMembersIdTemplatesRelFkPut**](TeamMemberApi.md#teammembersidtemplatesrelfkput) | **PUT** /TeamMembers/{id}/templates/rel/{fk} | Add a related item by id for templates.
[**TeamMembersIdTweakTemplateFoldersGet**](TeamMemberApi.md#teammembersidtweaktemplatefoldersget) | **GET** /TeamMembers/{id}/tweakTemplateFolders | List Tweak Templates Folders
[**TeamMembersIdTweakTemplateFoldersNkGet**](TeamMemberApi.md#teammembersidtweaktemplatefoldersnkget) | **GET** /TeamMembers/{id}/tweakTemplateFolders/{nk} | Get Tweak Templates Folders details
[**TeamMembersIdTweakTemplateFoldersNkTemplatesFkGet**](TeamMemberApi.md#teammembersidtweaktemplatefoldersnktemplatesfkget) | **GET** /TeamMembers/{id}/tweakTemplateFolders/{nk}/templates/{fk} | Get Tweak Template details within a Tweak Template Folder
[**TeamMembersIdTweakTemplateFoldersNkTemplatesGet**](TeamMemberApi.md#teammembersidtweaktemplatefoldersnktemplatesget) | **GET** /TeamMembers/{id}/tweakTemplateFolders/{nk}/templates | List Tweak Templates within a Tweak Template Folder
[**TeamMembersIdTweakTemplatesFkFlashvarsGet**](TeamMemberApi.md#teammembersidtweaktemplatesfkflashvarsget) | **GET** /TeamMembers/{id}/tweakTemplates/{fk}/flashvars | Find Template FlashVars by id
[**TeamMembersIdTweakTemplatesFkGet**](TeamMemberApi.md#teammembersidtweaktemplatesfkget) | **GET** /TeamMembers/{id}/tweakTemplates/{fk} | Get Tweak Template details
[**TeamMembersIdTweakTemplatesGet**](TeamMemberApi.md#teammembersidtweaktemplatesget) | **GET** /TeamMembers/{id}/tweakTemplates | List Tweak Templates
[**TeamMembersIdUploadedTemplatesCountGet**](TeamMemberApi.md#teammembersiduploadedtemplatescountget) | **GET** /TeamMembers/{id}/uploadedTemplates/count | Counts uploadedTemplates of TeamMember.
[**TeamMembersIdUploadedTemplatesDelete**](TeamMemberApi.md#teammembersiduploadedtemplatesdelete) | **DELETE** /TeamMembers/{id}/uploadedTemplates | Deletes all uploadedTemplates of this model.
[**TeamMembersIdUploadedTemplatesFkDelete**](TeamMemberApi.md#teammembersiduploadedtemplatesfkdelete) | **DELETE** /TeamMembers/{id}/uploadedTemplates/{fk} | Delete a related item by id for uploadedTemplates.
[**TeamMembersIdUploadedTemplatesFkGet**](TeamMemberApi.md#teammembersiduploadedtemplatesfkget) | **GET** /TeamMembers/{id}/uploadedTemplates/{fk} | Find a related item by id for uploadedTemplates.
[**TeamMembersIdUploadedTemplatesFkPut**](TeamMemberApi.md#teammembersiduploadedtemplatesfkput) | **PUT** /TeamMembers/{id}/uploadedTemplates/{fk} | Update a related item by id for uploadedTemplates.
[**TeamMembersIdUploadedTemplatesGet**](TeamMemberApi.md#teammembersiduploadedtemplatesget) | **GET** /TeamMembers/{id}/uploadedTemplates | Queries uploadedTemplates of TeamMember.
[**TeamMembersIdUploadedTemplatesPost**](TeamMemberApi.md#teammembersiduploadedtemplatespost) | **POST** /TeamMembers/{id}/uploadedTemplates | Creates a new instance in uploadedTemplates of this model.
[**TeamMembersIdWorkflowsCountGet**](TeamMemberApi.md#teammembersidworkflowscountget) | **GET** /TeamMembers/{id}/workflows/count | Counts workflows of TeamMember.
[**TeamMembersIdWorkflowsDelete**](TeamMemberApi.md#teammembersidworkflowsdelete) | **DELETE** /TeamMembers/{id}/workflows | Deletes all workflows of this model.
[**TeamMembersIdWorkflowsFkDelete**](TeamMemberApi.md#teammembersidworkflowsfkdelete) | **DELETE** /TeamMembers/{id}/workflows/{fk} | Delete a related item by id for workflows.
[**TeamMembersIdWorkflowsFkGet**](TeamMemberApi.md#teammembersidworkflowsfkget) | **GET** /TeamMembers/{id}/workflows/{fk} | Find a related item by id for workflows.
[**TeamMembersIdWorkflowsFkPut**](TeamMemberApi.md#teammembersidworkflowsfkput) | **PUT** /TeamMembers/{id}/workflows/{fk} | Update a related item by id for workflows.
[**TeamMembersIdWorkflowsGet**](TeamMemberApi.md#teammembersidworkflowsget) | **GET** /TeamMembers/{id}/workflows | Queries workflows of TeamMember.
[**TeamMembersIdWorkflowsPost**](TeamMemberApi.md#teammembersidworkflowspost) | **POST** /TeamMembers/{id}/workflows | Creates a new instance in workflows of this model.
[**TeamMembersPatch**](TeamMemberApi.md#teammemberspatch) | **PATCH** /TeamMembers | Patch an existing model instance or insert a new one into the data source.
[**TeamMembersPost**](TeamMemberApi.md#teammemberspost) | **POST** /TeamMembers | Create a new instance of the model and persist it into the data source.
[**TeamMembersPut**](TeamMemberApi.md#teammembersput) | **PUT** /TeamMembers | Replace an existing model instance or insert a new one into the data source.
[**TeamMembersReplaceOrCreatePost**](TeamMemberApi.md#teammembersreplaceorcreatepost) | **POST** /TeamMembers/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamMembersUpdatePost**](TeamMemberApi.md#teammembersupdatepost) | **POST** /TeamMembers/update | Update instances of the model matched by {{where}} from the data source.
[**TeamMembersUpsertWithWherePost**](TeamMemberApi.md#teammembersupsertwithwherepost) | **POST** /TeamMembers/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teammemberschangestreamget"></a>
# **TeamMembersChangeStreamGet**
> System.IO.Stream TeamMembersChangeStreamGet (string options = null)

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
    public class TeamMembersChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamMembersChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersChangeStreamGet: " + e.Message );
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

<a name="teammemberschangestreampost"></a>
# **TeamMembersChangeStreamPost**
> System.IO.Stream TeamMembersChangeStreamPost (string options = null)

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
    public class TeamMembersChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamMembersChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersChangeStreamPost: " + e.Message );
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

<a name="teammemberscountget"></a>
# **TeamMembersCountGet**
> InlineResponse2001 TeamMembersCountGet (string where = null)

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
    public class TeamMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.TeamMembersCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersCountGet: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersfindoneget"></a>
# **TeamMembersFindOneGet**
> TeamMember TeamMembersFindOneGet (string filter = null)

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
    public class TeamMembersFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TeamMember result = apiInstance.TeamMembersFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersFindOneGet: " + e.Message );
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

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersget"></a>
# **TeamMembersGet**
> List<TeamMember> TeamMembersGet (string filter = null)

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
    public class TeamMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TeamMember&gt; result = apiInstance.TeamMembersGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersGet: " + e.Message );
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

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidassigneddesignscountget"></a>
# **TeamMembersIdAssignedDesignsCountGet**
> InlineResponse2001 TeamMembersIdAssignedDesignsCountGet (string id, string where = null)

Counts assignedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdAssignedDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts assignedDesigns of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdAssignedDesignsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdAssignedDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidassigneddesignsdelete"></a>
# **TeamMembersIdAssignedDesignsDelete**
> void TeamMembersIdAssignedDesignsDelete (string id)

Deletes all assignedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdAssignedDesignsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all assignedDesigns of this model.
                apiInstance.TeamMembersIdAssignedDesignsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdAssignedDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidassigneddesignsfkdelete"></a>
# **TeamMembersIdAssignedDesignsFkDelete**
> void TeamMembersIdAssignedDesignsFkDelete (string id, string fk)

Delete a related item by id for assignedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdAssignedDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for assignedDesigns

            try
            {
                // Delete a related item by id for assignedDesigns.
                apiInstance.TeamMembersIdAssignedDesignsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdAssignedDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for assignedDesigns | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidassigneddesignsfkget"></a>
# **TeamMembersIdAssignedDesignsFkGet**
> Design TeamMembersIdAssignedDesignsFkGet (string id, string fk)

Find a related item by id for assignedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdAssignedDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for assignedDesigns

            try
            {
                // Find a related item by id for assignedDesigns.
                Design result = apiInstance.TeamMembersIdAssignedDesignsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdAssignedDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for assignedDesigns | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidassigneddesignsfkput"></a>
# **TeamMembersIdAssignedDesignsFkPut**
> Design TeamMembersIdAssignedDesignsFkPut (string id, string fk, Design data = null)

Update a related item by id for assignedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdAssignedDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for assignedDesigns
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for assignedDesigns.
                Design result = apiInstance.TeamMembersIdAssignedDesignsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdAssignedDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for assignedDesigns | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidassigneddesignsget"></a>
# **TeamMembersIdAssignedDesignsGet**
> List<Design> TeamMembersIdAssignedDesignsGet (string id, string filter = null)

Queries assignedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdAssignedDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries assignedDesigns of TeamMember.
                List&lt;Design&gt; result = apiInstance.TeamMembersIdAssignedDesignsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdAssignedDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidassigneddesignspost"></a>
# **TeamMembersIdAssignedDesignsPost**
> Design TeamMembersIdAssignedDesignsPost (string id, Design data = null)

Creates a new instance in assignedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdAssignedDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in assignedDesigns of this model.
                Design result = apiInstance.TeamMembersIdAssignedDesignsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdAssignedDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignscountget"></a>
# **TeamMembersIdCommentedDesignsCountGet**
> InlineResponse2001 TeamMembersIdCommentedDesignsCountGet (string id, string where = null)

Counts commentedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts commentedDesigns of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdCommentedDesignsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignsdelete"></a>
# **TeamMembersIdCommentedDesignsDelete**
> void TeamMembersIdCommentedDesignsDelete (string id)

Deletes all commentedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all commentedDesigns of this model.
                apiInstance.TeamMembersIdCommentedDesignsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignsfkdelete"></a>
# **TeamMembersIdCommentedDesignsFkDelete**
> void TeamMembersIdCommentedDesignsFkDelete (string id, string fk)

Delete a related item by id for commentedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for commentedDesigns

            try
            {
                // Delete a related item by id for commentedDesigns.
                apiInstance.TeamMembersIdCommentedDesignsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for commentedDesigns | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignsfkget"></a>
# **TeamMembersIdCommentedDesignsFkGet**
> Design TeamMembersIdCommentedDesignsFkGet (string id, string fk)

Find a related item by id for commentedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for commentedDesigns

            try
            {
                // Find a related item by id for commentedDesigns.
                Design result = apiInstance.TeamMembersIdCommentedDesignsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for commentedDesigns | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignsfkput"></a>
# **TeamMembersIdCommentedDesignsFkPut**
> Design TeamMembersIdCommentedDesignsFkPut (string id, string fk, Design data = null)

Update a related item by id for commentedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for commentedDesigns
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for commentedDesigns.
                Design result = apiInstance.TeamMembersIdCommentedDesignsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for commentedDesigns | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignsget"></a>
# **TeamMembersIdCommentedDesignsGet**
> List<Design> TeamMembersIdCommentedDesignsGet (string id, string filter = null)

Queries commentedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries commentedDesigns of TeamMember.
                List&lt;Design&gt; result = apiInstance.TeamMembersIdCommentedDesignsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignspost"></a>
# **TeamMembersIdCommentedDesignsPost**
> Design TeamMembersIdCommentedDesignsPost (string id, Design data = null)

Creates a new instance in commentedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in commentedDesigns of this model.
                Design result = apiInstance.TeamMembersIdCommentedDesignsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignsrelfkdelete"></a>
# **TeamMembersIdCommentedDesignsRelFkDelete**
> void TeamMembersIdCommentedDesignsRelFkDelete (string id, string fk)

Remove the commentedDesigns relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for commentedDesigns

            try
            {
                // Remove the commentedDesigns relation to an item by id.
                apiInstance.TeamMembersIdCommentedDesignsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for commentedDesigns | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignsrelfkhead"></a>
# **TeamMembersIdCommentedDesignsRelFkHead**
> bool? TeamMembersIdCommentedDesignsRelFkHead (string id, string fk)

Check the existence of commentedDesigns relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for commentedDesigns

            try
            {
                // Check the existence of commentedDesigns relation to an item by id.
                bool? result = apiInstance.TeamMembersIdCommentedDesignsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for commentedDesigns | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcommenteddesignsrelfkput"></a>
# **TeamMembersIdCommentedDesignsRelFkPut**
> DesignComment TeamMembersIdCommentedDesignsRelFkPut (string id, string fk, DesignComment data = null)

Add a related item by id for commentedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCommentedDesignsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for commentedDesigns
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Add a related item by id for commentedDesigns.
                DesignComment result = apiInstance.TeamMembersIdCommentedDesignsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCommentedDesignsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for commentedDesigns | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidcustomerget"></a>
# **TeamMembersIdCustomerGet**
> Customer TeamMembersIdCustomerGet (string id, bool? refresh = null)

Fetches belongsTo relation customer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdCustomerGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation customer.
                Customer result = apiInstance.TeamMembersIdCustomerGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdCustomerGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddelete"></a>
# **TeamMembersIdDelete**
> Object TeamMembersIdDelete (string id)

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
    public class TeamMembersIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamMembersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDelete: " + e.Message );
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

<a name="teammembersiddesigncommentscountget"></a>
# **TeamMembersIdDesignCommentsCountGet**
> InlineResponse2001 TeamMembersIdDesignCommentsCountGet (string id, string where = null)

Counts designComments of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignCommentsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designComments of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdDesignCommentsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignCommentsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesigncommentsdelete"></a>
# **TeamMembersIdDesignCommentsDelete**
> void TeamMembersIdDesignCommentsDelete (string id)

Deletes all designComments of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignCommentsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all designComments of this model.
                apiInstance.TeamMembersIdDesignCommentsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignCommentsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesigncommentsfkdelete"></a>
# **TeamMembersIdDesignCommentsFkDelete**
> void TeamMembersIdDesignCommentsFkDelete (string id, string fk)

Delete a related item by id for designComments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignCommentsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designComments

            try
            {
                // Delete a related item by id for designComments.
                apiInstance.TeamMembersIdDesignCommentsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignCommentsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for designComments | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesigncommentsfkget"></a>
# **TeamMembersIdDesignCommentsFkGet**
> DesignComment TeamMembersIdDesignCommentsFkGet (string id, string fk)

Find a related item by id for designComments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignCommentsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designComments

            try
            {
                // Find a related item by id for designComments.
                DesignComment result = apiInstance.TeamMembersIdDesignCommentsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignCommentsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for designComments | 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesigncommentsfkput"></a>
# **TeamMembersIdDesignCommentsFkPut**
> DesignComment TeamMembersIdDesignCommentsFkPut (string id, string fk, DesignComment data = null)

Update a related item by id for designComments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignCommentsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designComments
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Update a related item by id for designComments.
                DesignComment result = apiInstance.TeamMembersIdDesignCommentsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignCommentsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for designComments | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesigncommentsget"></a>
# **TeamMembersIdDesignCommentsGet**
> List<DesignComment> TeamMembersIdDesignCommentsGet (string id, string filter = null)

Queries designComments of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignCommentsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designComments of TeamMember.
                List&lt;DesignComment&gt; result = apiInstance.TeamMembersIdDesignCommentsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignCommentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignComment>**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesigncommentspost"></a>
# **TeamMembersIdDesignCommentsPost**
> DesignComment TeamMembersIdDesignCommentsPost (string id, DesignComment data = null)

Creates a new instance in designComments of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignCommentsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Creates a new instance in designComments of this model.
                DesignComment result = apiInstance.TeamMembersIdDesignCommentsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignCommentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignfolderscountget"></a>
# **TeamMembersIdDesignFoldersCountGet**
> InlineResponse2001 TeamMembersIdDesignFoldersCountGet (string id, string where = null)

Counts designFolders of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designFolders of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdDesignFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignfoldersdelete"></a>
# **TeamMembersIdDesignFoldersDelete**
> void TeamMembersIdDesignFoldersDelete (string id)

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
    public class TeamMembersIdDesignFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all designFolders of this model.
                apiInstance.TeamMembersIdDesignFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignfoldersfkdelete"></a>
# **TeamMembersIdDesignFoldersFkDelete**
> void TeamMembersIdDesignFoldersFkDelete (string id, string fk)

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
    public class TeamMembersIdDesignFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designFolders

            try
            {
                // Delete a related item by id for designFolders.
                apiInstance.TeamMembersIdDesignFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for designFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignfoldersfkget"></a>
# **TeamMembersIdDesignFoldersFkGet**
> DesignFolder TeamMembersIdDesignFoldersFkGet (string id, string fk)

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
    public class TeamMembersIdDesignFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designFolders

            try
            {
                // Find a related item by id for designFolders.
                DesignFolder result = apiInstance.TeamMembersIdDesignFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for designFolders | 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignfoldersfkput"></a>
# **TeamMembersIdDesignFoldersFkPut**
> DesignFolder TeamMembersIdDesignFoldersFkPut (string id, string fk, DesignFolder data = null)

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
    public class TeamMembersIdDesignFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designFolders
            var data = new DesignFolder(); // DesignFolder |  (optional) 

            try
            {
                // Update a related item by id for designFolders.
                DesignFolder result = apiInstance.TeamMembersIdDesignFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersiddesignfoldersget"></a>
# **TeamMembersIdDesignFoldersGet**
> List<DesignFolder> TeamMembersIdDesignFoldersGet (string id, string filter = null)

Queries designFolders of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designFolders of TeamMember.
                List&lt;DesignFolder&gt; result = apiInstance.TeamMembersIdDesignFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignFolder>**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignfolderspost"></a>
# **TeamMembersIdDesignFoldersPost**
> DesignFolder TeamMembersIdDesignFoldersPost (string id, DesignFolder data = null)

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
    public class TeamMembersIdDesignFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new DesignFolder(); // DesignFolder |  (optional) 

            try
            {
                // Creates a new instance in designFolders of this model.
                DesignFolder result = apiInstance.TeamMembersIdDesignFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**DesignFolder**](DesignFolder.md)|  | [optional] 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignsharescountget"></a>
# **TeamMembersIdDesignSharesCountGet**
> InlineResponse2001 TeamMembersIdDesignSharesCountGet (string id, string where = null)

Counts designShares of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignSharesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designShares of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdDesignSharesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignSharesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignsharesdelete"></a>
# **TeamMembersIdDesignSharesDelete**
> void TeamMembersIdDesignSharesDelete (string id)

Deletes all designShares of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignSharesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all designShares of this model.
                apiInstance.TeamMembersIdDesignSharesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignSharesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignsharesfkdelete"></a>
# **TeamMembersIdDesignSharesFkDelete**
> void TeamMembersIdDesignSharesFkDelete (string id, string fk)

Delete a related item by id for designShares.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignSharesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designShares

            try
            {
                // Delete a related item by id for designShares.
                apiInstance.TeamMembersIdDesignSharesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignSharesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for designShares | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignsharesfkget"></a>
# **TeamMembersIdDesignSharesFkGet**
> DesignMember TeamMembersIdDesignSharesFkGet (string id, string fk)

Find a related item by id for designShares.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignSharesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designShares

            try
            {
                // Find a related item by id for designShares.
                DesignMember result = apiInstance.TeamMembersIdDesignSharesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignSharesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for designShares | 

### Return type

[**DesignMember**](DesignMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignsharesfkput"></a>
# **TeamMembersIdDesignSharesFkPut**
> DesignMember TeamMembersIdDesignSharesFkPut (string id, string fk, DesignMember data = null)

Update a related item by id for designShares.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignSharesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for designShares
            var data = new DesignMember(); // DesignMember |  (optional) 

            try
            {
                // Update a related item by id for designShares.
                DesignMember result = apiInstance.TeamMembersIdDesignSharesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignSharesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for designShares | 
 **data** | [**DesignMember**](DesignMember.md)|  | [optional] 

### Return type

[**DesignMember**](DesignMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignsharesget"></a>
# **TeamMembersIdDesignSharesGet**
> List<DesignMember> TeamMembersIdDesignSharesGet (string id, string filter = null)

Queries designShares of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignSharesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designShares of TeamMember.
                List&lt;DesignMember&gt; result = apiInstance.TeamMembersIdDesignSharesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignSharesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignMember>**](DesignMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiddesignsharespost"></a>
# **TeamMembersIdDesignSharesPost**
> DesignMember TeamMembersIdDesignSharesPost (string id, DesignMember data = null)

Creates a new instance in designShares of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdDesignSharesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new DesignMember(); // DesignMember |  (optional) 

            try
            {
                // Creates a new instance in designShares of this model.
                DesignMember result = apiInstance.TeamMembersIdDesignSharesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdDesignSharesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**DesignMember**](DesignMember.md)|  | [optional] 

### Return type

[**DesignMember**](DesignMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidexistsget"></a>
# **TeamMembersIdExistsGet**
> InlineResponse2002 TeamMembersIdExistsGet (string id)

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
    public class TeamMembersIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamMembersIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdExistsGet: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidget"></a>
# **TeamMembersIdGet**
> TeamMember TeamMembersIdGet (string id, string filter = null)

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
    public class TeamMembersIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TeamMember result = apiInstance.TeamMembersIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdGet: " + e.Message );
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

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidhead"></a>
# **TeamMembersIdHead**
> InlineResponse2002 TeamMembersIdHead (string id)

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
    public class TeamMembersIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamMembersIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdHead: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefolderscountget"></a>
# **TeamMembersIdImageFoldersCountGet**
> InlineResponse2001 TeamMembersIdImageFoldersCountGet (string id, string where = null)

Counts imageFolders of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdImageFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts imageFolders of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdImageFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefoldersdelete"></a>
# **TeamMembersIdImageFoldersDelete**
> void TeamMembersIdImageFoldersDelete (string id)

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
    public class TeamMembersIdImageFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all imageFolders of this model.
                apiInstance.TeamMembersIdImageFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefoldersfkdelete"></a>
# **TeamMembersIdImageFoldersFkDelete**
> void TeamMembersIdImageFoldersFkDelete (string id, string fk)

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
    public class TeamMembersIdImageFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Delete a related item by id for imageFolders.
                apiInstance.TeamMembersIdImageFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefoldersfkget"></a>
# **TeamMembersIdImageFoldersFkGet**
> ImageFolder TeamMembersIdImageFoldersFkGet (string id, string fk)

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
    public class TeamMembersIdImageFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Find a related item by id for imageFolders.
                ImageFolder result = apiInstance.TeamMembersIdImageFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefoldersfkput"></a>
# **TeamMembersIdImageFoldersFkPut**
> ImageFolder TeamMembersIdImageFoldersFkPut (string id, string fk, ImageFolder data = null)

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
    public class TeamMembersIdImageFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Update a related item by id for imageFolders.
                ImageFolder result = apiInstance.TeamMembersIdImageFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidimagefoldersget"></a>
# **TeamMembersIdImageFoldersGet**
> List<ImageFolder> TeamMembersIdImageFoldersGet (string id, string filter = null)

Queries imageFolders of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdImageFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries imageFolders of TeamMember.
                List&lt;ImageFolder&gt; result = apiInstance.TeamMembersIdImageFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ImageFolder>**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefolderspost"></a>
# **TeamMembersIdImageFoldersPost**
> ImageFolder TeamMembersIdImageFoldersPost (string id, ImageFolder data = null)

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
    public class TeamMembersIdImageFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Creates a new instance in imageFolders of this model.
                ImageFolder result = apiInstance.TeamMembersIdImageFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefoldersrelfkdelete"></a>
# **TeamMembersIdImageFoldersRelFkDelete**
> void TeamMembersIdImageFoldersRelFkDelete (string id, string fk)

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
    public class TeamMembersIdImageFoldersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Remove the imageFolders relation to an item by id.
                apiInstance.TeamMembersIdImageFoldersRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefoldersrelfkhead"></a>
# **TeamMembersIdImageFoldersRelFkHead**
> bool? TeamMembersIdImageFoldersRelFkHead (string id, string fk)

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
    public class TeamMembersIdImageFoldersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Check the existence of imageFolders relation to an item by id.
                bool? result = apiInstance.TeamMembersIdImageFoldersRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidimagefoldersrelfkput"></a>
# **TeamMembersIdImageFoldersRelFkPut**
> ImageFolderMember TeamMembersIdImageFoldersRelFkPut (string id, string fk, ImageFolderMember data = null)

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
    public class TeamMembersIdImageFoldersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new ImageFolderMember(); // ImageFolderMember |  (optional) 

            try
            {
                // Add a related item by id for imageFolders.
                ImageFolderMember result = apiInstance.TeamMembersIdImageFoldersRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdImageFoldersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for imageFolders | 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)|  | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidinvitationticketscountget"></a>
# **TeamMembersIdInvitationTicketsCountGet**
> InlineResponse2001 TeamMembersIdInvitationTicketsCountGet (string id, string where = null)

Counts invitationTickets of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdInvitationTicketsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts invitationTickets of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdInvitationTicketsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdInvitationTicketsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidinvitationticketsdelete"></a>
# **TeamMembersIdInvitationTicketsDelete**
> void TeamMembersIdInvitationTicketsDelete (string id)

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
    public class TeamMembersIdInvitationTicketsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all invitationTickets of this model.
                apiInstance.TeamMembersIdInvitationTicketsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdInvitationTicketsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidinvitationticketsfkdelete"></a>
# **TeamMembersIdInvitationTicketsFkDelete**
> void TeamMembersIdInvitationTicketsFkDelete (string id, string fk)

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
    public class TeamMembersIdInvitationTicketsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for invitationTickets

            try
            {
                // Delete a related item by id for invitationTickets.
                apiInstance.TeamMembersIdInvitationTicketsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdInvitationTicketsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for invitationTickets | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidinvitationticketsfkget"></a>
# **TeamMembersIdInvitationTicketsFkGet**
> InvitationTicket TeamMembersIdInvitationTicketsFkGet (string id, string fk)

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
    public class TeamMembersIdInvitationTicketsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for invitationTickets

            try
            {
                // Find a related item by id for invitationTickets.
                InvitationTicket result = apiInstance.TeamMembersIdInvitationTicketsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdInvitationTicketsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for invitationTickets | 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidinvitationticketsfkput"></a>
# **TeamMembersIdInvitationTicketsFkPut**
> InvitationTicket TeamMembersIdInvitationTicketsFkPut (string id, string fk, InvitationTicket data = null)

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
    public class TeamMembersIdInvitationTicketsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for invitationTickets
            var data = new InvitationTicket(); // InvitationTicket |  (optional) 

            try
            {
                // Update a related item by id for invitationTickets.
                InvitationTicket result = apiInstance.TeamMembersIdInvitationTicketsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdInvitationTicketsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidinvitationticketsget"></a>
# **TeamMembersIdInvitationTicketsGet**
> List<InvitationTicket> TeamMembersIdInvitationTicketsGet (string id, string filter = null)

Queries invitationTickets of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdInvitationTicketsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries invitationTickets of TeamMember.
                List&lt;InvitationTicket&gt; result = apiInstance.TeamMembersIdInvitationTicketsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdInvitationTicketsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<InvitationTicket>**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidinvitationticketspost"></a>
# **TeamMembersIdInvitationTicketsPost**
> InvitationTicket TeamMembersIdInvitationTicketsPost (string id, InvitationTicket data = null)

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
    public class TeamMembersIdInvitationTicketsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new InvitationTicket(); // InvitationTicket |  (optional) 

            try
            {
                // Creates a new instance in invitationTickets of this model.
                InvitationTicket result = apiInstance.TeamMembersIdInvitationTicketsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdInvitationTicketsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**InvitationTicket**](InvitationTicket.md)|  | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidinviteinviteepost"></a>
# **TeamMembersIdInviteInviteePost**
> InvitationTicket TeamMembersIdInviteInviteePost (string id, string id2, string invitee, TeamMember data = null)

Invite somebody to join the team

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdInviteInviteePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var invitee = invitee_example;  // string | 
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Invite somebody to join the team
                InvitationTicket result = apiInstance.TeamMembersIdInviteInviteePost(id, id2, invitee, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdInviteInviteePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **invitee** | **string**|  | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidnotificationscountget"></a>
# **TeamMembersIdNotificationsCountGet**
> InlineResponse2001 TeamMembersIdNotificationsCountGet (string id, string where = null)

Counts notifications of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdNotificationsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts notifications of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdNotificationsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdNotificationsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidnotificationsdelete"></a>
# **TeamMembersIdNotificationsDelete**
> void TeamMembersIdNotificationsDelete (string id)

Deletes all notifications of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdNotificationsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all notifications of this model.
                apiInstance.TeamMembersIdNotificationsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdNotificationsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidnotificationsfkdelete"></a>
# **TeamMembersIdNotificationsFkDelete**
> void TeamMembersIdNotificationsFkDelete (string id, string fk)

Delete a related item by id for notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdNotificationsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for notifications

            try
            {
                // Delete a related item by id for notifications.
                apiInstance.TeamMembersIdNotificationsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdNotificationsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for notifications | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidnotificationsfkget"></a>
# **TeamMembersIdNotificationsFkGet**
> Notification TeamMembersIdNotificationsFkGet (string id, string fk)

Find a related item by id for notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdNotificationsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for notifications

            try
            {
                // Find a related item by id for notifications.
                Notification result = apiInstance.TeamMembersIdNotificationsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdNotificationsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for notifications | 

### Return type

[**Notification**](Notification.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidnotificationsfkput"></a>
# **TeamMembersIdNotificationsFkPut**
> Notification TeamMembersIdNotificationsFkPut (string id, string fk, Notification data = null)

Update a related item by id for notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdNotificationsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for notifications
            var data = new Notification(); // Notification |  (optional) 

            try
            {
                // Update a related item by id for notifications.
                Notification result = apiInstance.TeamMembersIdNotificationsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdNotificationsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for notifications | 
 **data** | [**Notification**](Notification.md)|  | [optional] 

### Return type

[**Notification**](Notification.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidnotificationsget"></a>
# **TeamMembersIdNotificationsGet**
> List<Notification> TeamMembersIdNotificationsGet (string id, string filter = null)

Queries notifications of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdNotificationsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries notifications of TeamMember.
                List&lt;Notification&gt; result = apiInstance.TeamMembersIdNotificationsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdNotificationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Notification>**](Notification.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidnotificationspost"></a>
# **TeamMembersIdNotificationsPost**
> Notification TeamMembersIdNotificationsPost (string id, Notification data = null)

Creates a new instance in notifications of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdNotificationsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Notification(); // Notification |  (optional) 

            try
            {
                // Creates a new instance in notifications of this model.
                Notification result = apiInstance.TeamMembersIdNotificationsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdNotificationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Notification**](Notification.md)|  | [optional] 

### Return type

[**Notification**](Notification.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidpatch"></a>
# **TeamMembersIdPatch**
> TeamMember TeamMembersIdPatch (string id, TeamMember data = null)

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
    public class TeamMembersIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TeamMember result = apiInstance.TeamMembersIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsavailableget"></a>
# **TeamMembersIdPortalsAvailableGet**
> List<Portal> TeamMembersIdPortalsAvailableGet (string id, string id2, string filter = null)

Find all available Portals

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdPortalsAvailableGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all available Portals
                List&lt;Portal&gt; result = apiInstance.TeamMembersIdPortalsAvailableGet(id, id2, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsAvailableGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<Portal>**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalscountget"></a>
# **TeamMembersIdPortalsCountGet**
> InlineResponse2001 TeamMembersIdPortalsCountGet (string id, string where = null)

Counts portals of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdPortalsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portals of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdPortalsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsdelete"></a>
# **TeamMembersIdPortalsDelete**
> void TeamMembersIdPortalsDelete (string id)

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
    public class TeamMembersIdPortalsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all portals of this model.
                apiInstance.TeamMembersIdPortalsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsfkavailableget"></a>
# **TeamMembersIdPortalsFkAvailableGet**
> Portal TeamMembersIdPortalsFkAvailableGet (string id, string id2, string fk, string include = null)

Find available Portal by id

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdPortalsFkAvailableGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var fk = fk_example;  // string | 
            var include = include_example;  // string | Only include changes that match this filter (optional) 

            try
            {
                // Find available Portal by id
                Portal result = apiInstance.TeamMembersIdPortalsFkAvailableGet(id, id2, fk, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsFkAvailableGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **fk** | **string**|  | 
 **include** | **string**| Only include changes that match this filter | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsfkdelete"></a>
# **TeamMembersIdPortalsFkDelete**
> void TeamMembersIdPortalsFkDelete (string id, string fk)

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
    public class TeamMembersIdPortalsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Delete a related item by id for portals.
                apiInstance.TeamMembersIdPortalsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsfkget"></a>
# **TeamMembersIdPortalsFkGet**
> Portal TeamMembersIdPortalsFkGet (string id, string fk)

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
    public class TeamMembersIdPortalsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Find a related item by id for portals.
                Portal result = apiInstance.TeamMembersIdPortalsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for portals | 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsfklogoput"></a>
# **TeamMembersIdPortalsFkLogoPut**
> Portal TeamMembersIdPortalsFkLogoPut (string id, string id2, string fk, TeamMember data)

Change Portal logo

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdPortalsFkLogoPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Portal id
            var data = new TeamMember(); // TeamMember | Logo

            try
            {
                // Change Portal logo
                Portal result = apiInstance.TeamMembersIdPortalsFkLogoPut(id, id2, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsFkLogoPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **fk** | **string**| Portal id | 
 **data** | [**TeamMember**](TeamMember.md)| Logo | 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsfkput"></a>
# **TeamMembersIdPortalsFkPut**
> Portal TeamMembersIdPortalsFkPut (string id, string fk, Portal data = null)

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
    public class TeamMembersIdPortalsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Update a related item by id for portals.
                Portal result = apiInstance.TeamMembersIdPortalsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidportalsget"></a>
# **TeamMembersIdPortalsGet**
> List<Portal> TeamMembersIdPortalsGet (string id, string filter = null)

Queries portals of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdPortalsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portals of TeamMember.
                List&lt;Portal&gt; result = apiInstance.TeamMembersIdPortalsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Portal>**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsnkdesignsfkflashvarsget"></a>
# **TeamMembersIdPortalsNkDesignsFkFlashvarsGet**
> FlashVar TeamMembersIdPortalsNkDesignsFkFlashvarsGet (string id, string id2, string nk, string fk)

Find Design FlashVars within available Portal by id

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdPortalsNkDesignsFkFlashvarsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var nk = nk_example;  // string | 
            var fk = fk_example;  // string | 

            try
            {
                // Find Design FlashVars within available Portal by id
                FlashVar result = apiInstance.TeamMembersIdPortalsNkDesignsFkFlashvarsGet(id, id2, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsNkDesignsFkFlashvarsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **nk** | **string**|  | 
 **fk** | **string**|  | 

### Return type

[**FlashVar**](FlashVar.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsnktemplatesfkflashvarsget"></a>
# **TeamMembersIdPortalsNkTemplatesFkFlashvarsGet**
> FlashVar TeamMembersIdPortalsNkTemplatesFkFlashvarsGet (string id, string id2, string nk, string fk)

Find Template FlashVars within available Portal by id

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdPortalsNkTemplatesFkFlashvarsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var nk = nk_example;  // string | 
            var fk = fk_example;  // string | 

            try
            {
                // Find Template FlashVars within available Portal by id
                FlashVar result = apiInstance.TeamMembersIdPortalsNkTemplatesFkFlashvarsGet(id, id2, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsNkTemplatesFkFlashvarsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **nk** | **string**|  | 
 **fk** | **string**|  | 

### Return type

[**FlashVar**](FlashVar.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalspost"></a>
# **TeamMembersIdPortalsPost**
> Portal TeamMembersIdPortalsPost (string id, Portal data = null)

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
    public class TeamMembersIdPortalsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Creates a new instance in portals of this model.
                Portal result = apiInstance.TeamMembersIdPortalsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Portal**](Portal.md)|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsrelfkdelete"></a>
# **TeamMembersIdPortalsRelFkDelete**
> void TeamMembersIdPortalsRelFkDelete (string id, string fk)

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
    public class TeamMembersIdPortalsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Remove the portals relation to an item by id.
                apiInstance.TeamMembersIdPortalsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsrelfkhead"></a>
# **TeamMembersIdPortalsRelFkHead**
> bool? TeamMembersIdPortalsRelFkHead (string id, string fk)

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
    public class TeamMembersIdPortalsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Check the existence of portals relation to an item by id.
                bool? result = apiInstance.TeamMembersIdPortalsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for portals | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidportalsrelfkput"></a>
# **TeamMembersIdPortalsRelFkPut**
> PortalMember TeamMembersIdPortalsRelFkPut (string id, string fk, PortalMember data = null)

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
    public class TeamMembersIdPortalsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals
            var data = new PortalMember(); // PortalMember |  (optional) 

            try
            {
                // Add a related item by id for portals.
                PortalMember result = apiInstance.TeamMembersIdPortalsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPortalsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for portals | 
 **data** | [**PortalMember**](PortalMember.md)|  | [optional] 

### Return type

[**PortalMember**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidput"></a>
# **TeamMembersIdPut**
> TeamMember TeamMembersIdPut (string id, TeamMember data = null)

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
    public class TeamMembersIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | Model id
            var data = new TeamMember(); // TeamMember | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamMember result = apiInstance.TeamMembersIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamMember**](TeamMember.md)| Model instance data | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidreplacepost"></a>
# **TeamMembersIdReplacePost**
> TeamMember TeamMembersIdReplacePost (string id, TeamMember data = null)

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
    public class TeamMembersIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | Model id
            var data = new TeamMember(); // TeamMember | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamMember result = apiInstance.TeamMembersIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamMember**](TeamMember.md)| Model instance data | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignexportscountget"></a>
# **TeamMembersIdRequestedDesignExportsCountGet**
> InlineResponse2001 TeamMembersIdRequestedDesignExportsCountGet (string id, string where = null)

Counts requestedDesignExports of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignExportsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts requestedDesignExports of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdRequestedDesignExportsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignExportsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignexportsdelete"></a>
# **TeamMembersIdRequestedDesignExportsDelete**
> void TeamMembersIdRequestedDesignExportsDelete (string id)

Deletes all requestedDesignExports of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignExportsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all requestedDesignExports of this model.
                apiInstance.TeamMembersIdRequestedDesignExportsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignExportsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignexportsfkdelete"></a>
# **TeamMembersIdRequestedDesignExportsFkDelete**
> void TeamMembersIdRequestedDesignExportsFkDelete (string id, string fk)

Delete a related item by id for requestedDesignExports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignExportsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for requestedDesignExports

            try
            {
                // Delete a related item by id for requestedDesignExports.
                apiInstance.TeamMembersIdRequestedDesignExportsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignExportsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for requestedDesignExports | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignexportsfkget"></a>
# **TeamMembersIdRequestedDesignExportsFkGet**
> DesignExport TeamMembersIdRequestedDesignExportsFkGet (string id, string fk)

Find a related item by id for requestedDesignExports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignExportsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for requestedDesignExports

            try
            {
                // Find a related item by id for requestedDesignExports.
                DesignExport result = apiInstance.TeamMembersIdRequestedDesignExportsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignExportsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for requestedDesignExports | 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignexportsfkput"></a>
# **TeamMembersIdRequestedDesignExportsFkPut**
> DesignExport TeamMembersIdRequestedDesignExportsFkPut (string id, string fk, DesignExport data = null)

Update a related item by id for requestedDesignExports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignExportsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for requestedDesignExports
            var data = new DesignExport(); // DesignExport |  (optional) 

            try
            {
                // Update a related item by id for requestedDesignExports.
                DesignExport result = apiInstance.TeamMembersIdRequestedDesignExportsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignExportsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for requestedDesignExports | 
 **data** | [**DesignExport**](DesignExport.md)|  | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignexportsget"></a>
# **TeamMembersIdRequestedDesignExportsGet**
> List<DesignExport> TeamMembersIdRequestedDesignExportsGet (string id, string filter = null)

Queries requestedDesignExports of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignExportsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries requestedDesignExports of TeamMember.
                List&lt;DesignExport&gt; result = apiInstance.TeamMembersIdRequestedDesignExportsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignExportsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignExport>**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignexportspost"></a>
# **TeamMembersIdRequestedDesignExportsPost**
> DesignExport TeamMembersIdRequestedDesignExportsPost (string id, DesignExport data = null)

Creates a new instance in requestedDesignExports of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignExportsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new DesignExport(); // DesignExport |  (optional) 

            try
            {
                // Creates a new instance in requestedDesignExports of this model.
                DesignExport result = apiInstance.TeamMembersIdRequestedDesignExportsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignExportsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**DesignExport**](DesignExport.md)|  | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignscountget"></a>
# **TeamMembersIdRequestedDesignsCountGet**
> InlineResponse2001 TeamMembersIdRequestedDesignsCountGet (string id, string where = null)

Counts requestedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts requestedDesigns of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdRequestedDesignsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignsdelete"></a>
# **TeamMembersIdRequestedDesignsDelete**
> void TeamMembersIdRequestedDesignsDelete (string id)

Deletes all requestedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all requestedDesigns of this model.
                apiInstance.TeamMembersIdRequestedDesignsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignsfkdelete"></a>
# **TeamMembersIdRequestedDesignsFkDelete**
> void TeamMembersIdRequestedDesignsFkDelete (string id, string fk)

Delete a related item by id for requestedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for requestedDesigns

            try
            {
                // Delete a related item by id for requestedDesigns.
                apiInstance.TeamMembersIdRequestedDesignsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for requestedDesigns | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignsfkget"></a>
# **TeamMembersIdRequestedDesignsFkGet**
> Design TeamMembersIdRequestedDesignsFkGet (string id, string fk)

Find a related item by id for requestedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for requestedDesigns

            try
            {
                // Find a related item by id for requestedDesigns.
                Design result = apiInstance.TeamMembersIdRequestedDesignsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for requestedDesigns | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignsfkput"></a>
# **TeamMembersIdRequestedDesignsFkPut**
> Design TeamMembersIdRequestedDesignsFkPut (string id, string fk, Design data = null)

Update a related item by id for requestedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for requestedDesigns
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for requestedDesigns.
                Design result = apiInstance.TeamMembersIdRequestedDesignsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for requestedDesigns | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignsget"></a>
# **TeamMembersIdRequestedDesignsGet**
> List<Design> TeamMembersIdRequestedDesignsGet (string id, string filter = null)

Queries requestedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries requestedDesigns of TeamMember.
                List&lt;Design&gt; result = apiInstance.TeamMembersIdRequestedDesignsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrequesteddesignspost"></a>
# **TeamMembersIdRequestedDesignsPost**
> Design TeamMembersIdRequestedDesignsPost (string id, Design data = null)

Creates a new instance in requestedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdRequestedDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in requestedDesigns of this model.
                Design result = apiInstance.TeamMembersIdRequestedDesignsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdRequestedDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrevieweddesignscountget"></a>
# **TeamMembersIdReviewedDesignsCountGet**
> InlineResponse2001 TeamMembersIdReviewedDesignsCountGet (string id, string where = null)

Counts reviewedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdReviewedDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts reviewedDesigns of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdReviewedDesignsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdReviewedDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrevieweddesignsdelete"></a>
# **TeamMembersIdReviewedDesignsDelete**
> void TeamMembersIdReviewedDesignsDelete (string id)

Deletes all reviewedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdReviewedDesignsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all reviewedDesigns of this model.
                apiInstance.TeamMembersIdReviewedDesignsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdReviewedDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrevieweddesignsfkdelete"></a>
# **TeamMembersIdReviewedDesignsFkDelete**
> void TeamMembersIdReviewedDesignsFkDelete (string id, string fk)

Delete a related item by id for reviewedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdReviewedDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for reviewedDesigns

            try
            {
                // Delete a related item by id for reviewedDesigns.
                apiInstance.TeamMembersIdReviewedDesignsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdReviewedDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for reviewedDesigns | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrevieweddesignsfkget"></a>
# **TeamMembersIdReviewedDesignsFkGet**
> Design TeamMembersIdReviewedDesignsFkGet (string id, string fk)

Find a related item by id for reviewedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdReviewedDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for reviewedDesigns

            try
            {
                // Find a related item by id for reviewedDesigns.
                Design result = apiInstance.TeamMembersIdReviewedDesignsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdReviewedDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for reviewedDesigns | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrevieweddesignsfkput"></a>
# **TeamMembersIdReviewedDesignsFkPut**
> Design TeamMembersIdReviewedDesignsFkPut (string id, string fk, Design data = null)

Update a related item by id for reviewedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdReviewedDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for reviewedDesigns
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for reviewedDesigns.
                Design result = apiInstance.TeamMembersIdReviewedDesignsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdReviewedDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for reviewedDesigns | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrevieweddesignsget"></a>
# **TeamMembersIdReviewedDesignsGet**
> List<Design> TeamMembersIdReviewedDesignsGet (string id, string filter = null)

Queries reviewedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdReviewedDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries reviewedDesigns of TeamMember.
                List&lt;Design&gt; result = apiInstance.TeamMembersIdReviewedDesignsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdReviewedDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidrevieweddesignspost"></a>
# **TeamMembersIdReviewedDesignsPost**
> Design TeamMembersIdReviewedDesignsPost (string id, Design data = null)

Creates a new instance in reviewedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdReviewedDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in reviewedDesigns of this model.
                Design result = apiInstance.TeamMembersIdReviewedDesignsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdReviewedDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignscountget"></a>
# **TeamMembersIdSharedDesignsCountGet**
> InlineResponse2001 TeamMembersIdSharedDesignsCountGet (string id, string where = null)

Counts sharedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts sharedDesigns of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdSharedDesignsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignsdelete"></a>
# **TeamMembersIdSharedDesignsDelete**
> void TeamMembersIdSharedDesignsDelete (string id)

Deletes all sharedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all sharedDesigns of this model.
                apiInstance.TeamMembersIdSharedDesignsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignsfkdelete"></a>
# **TeamMembersIdSharedDesignsFkDelete**
> void TeamMembersIdSharedDesignsFkDelete (string id, string fk)

Delete a related item by id for sharedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for sharedDesigns

            try
            {
                // Delete a related item by id for sharedDesigns.
                apiInstance.TeamMembersIdSharedDesignsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for sharedDesigns | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignsfkget"></a>
# **TeamMembersIdSharedDesignsFkGet**
> Design TeamMembersIdSharedDesignsFkGet (string id, string fk)

Find a related item by id for sharedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for sharedDesigns

            try
            {
                // Find a related item by id for sharedDesigns.
                Design result = apiInstance.TeamMembersIdSharedDesignsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for sharedDesigns | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignsfkput"></a>
# **TeamMembersIdSharedDesignsFkPut**
> Design TeamMembersIdSharedDesignsFkPut (string id, string fk, Design data = null)

Update a related item by id for sharedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for sharedDesigns
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for sharedDesigns.
                Design result = apiInstance.TeamMembersIdSharedDesignsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for sharedDesigns | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignsget"></a>
# **TeamMembersIdSharedDesignsGet**
> List<Design> TeamMembersIdSharedDesignsGet (string id, string filter = null)

Queries sharedDesigns of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries sharedDesigns of TeamMember.
                List&lt;Design&gt; result = apiInstance.TeamMembersIdSharedDesignsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignspost"></a>
# **TeamMembersIdSharedDesignsPost**
> Design TeamMembersIdSharedDesignsPost (string id, Design data = null)

Creates a new instance in sharedDesigns of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in sharedDesigns of this model.
                Design result = apiInstance.TeamMembersIdSharedDesignsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignsrelfkdelete"></a>
# **TeamMembersIdSharedDesignsRelFkDelete**
> void TeamMembersIdSharedDesignsRelFkDelete (string id, string fk)

Remove the sharedDesigns relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for sharedDesigns

            try
            {
                // Remove the sharedDesigns relation to an item by id.
                apiInstance.TeamMembersIdSharedDesignsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for sharedDesigns | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignsrelfkhead"></a>
# **TeamMembersIdSharedDesignsRelFkHead**
> bool? TeamMembersIdSharedDesignsRelFkHead (string id, string fk)

Check the existence of sharedDesigns relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for sharedDesigns

            try
            {
                // Check the existence of sharedDesigns relation to an item by id.
                bool? result = apiInstance.TeamMembersIdSharedDesignsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for sharedDesigns | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidshareddesignsrelfkput"></a>
# **TeamMembersIdSharedDesignsRelFkPut**
> DesignMember TeamMembersIdSharedDesignsRelFkPut (string id, string fk, DesignMember data = null)

Add a related item by id for sharedDesigns.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdSharedDesignsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for sharedDesigns
            var data = new DesignMember(); // DesignMember |  (optional) 

            try
            {
                // Add a related item by id for sharedDesigns.
                DesignMember result = apiInstance.TeamMembersIdSharedDesignsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdSharedDesignsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for sharedDesigns | 
 **data** | [**DesignMember**](DesignMember.md)|  | [optional] 

### Return type

[**DesignMember**](DesignMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtargetmodeltargetidinviteinviteepost"></a>
# **TeamMembersIdTargetModelTargetIdInviteInviteePost**
> InvitationTicket TeamMembersIdTargetModelTargetIdInviteInviteePost (string id, string id2, string targetModel, string targetId, string invitee, TeamMember data = null)

Invite somebody to join a team, portal or other targets

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTargetModelTargetIdInviteInviteePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var targetModel = targetModel_example;  // string | 
            var targetId = targetId_example;  // string | 
            var invitee = invitee_example;  // string | 
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Invite somebody to join a team, portal or other targets
                InvitationTicket result = apiInstance.TeamMembersIdTargetModelTargetIdInviteInviteePost(id, id2, targetModel, targetId, invitee, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTargetModelTargetIdInviteInviteePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **targetModel** | **string**|  | 
 **targetId** | **string**|  | 
 **invitee** | **string**|  | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtargetmodeltargetidinvitepost"></a>
# **TeamMembersIdTargetModelTargetIdInvitePost**
> List<InvitationTicket> TeamMembersIdTargetModelTargetIdInvitePost (string id, string id2, string targetModel, string targetId, List<Object> data = null)

Invite a group of people to join a team, portal or other targets

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTargetModelTargetIdInvitePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var targetModel = targetModel_example;  // string | 
            var targetId = targetId_example;  // string | 
            var data = ;  // List<Object> |  (optional) 

            try
            {
                // Invite a group of people to join a team, portal or other targets
                List&lt;InvitationTicket&gt; result = apiInstance.TeamMembersIdTargetModelTargetIdInvitePost(id, id2, targetModel, targetId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTargetModelTargetIdInvitePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **targetModel** | **string**|  | 
 **targetId** | **string**|  | 
 **data** | **List<Object>**|  | [optional] 

### Return type

[**List<InvitationTicket>**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingavailableplansget"></a>
# **TeamMembersIdTeamBillingAvailablePlansGet**
> List<BillingPlan> TeamMembersIdTeamBillingAvailablePlansGet (string id, string filter = null)

Get Available Plans

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingAvailablePlansGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Get Available Plans
                List&lt;BillingPlan&gt; result = apiInstance.TeamMembersIdTeamBillingAvailablePlansGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingAvailablePlansGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<BillingPlan>**](BillingPlan.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingbankaccountdelete"></a>
# **TeamMembersIdTeamBillingBankAccountDelete**
> Billing TeamMembersIdTeamBillingBankAccountDelete (string id)

Delete Team Billing BankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingBankAccountDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Delete Team Billing BankAccount
                Billing result = apiInstance.TeamMembersIdTeamBillingBankAccountDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingBankAccountDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingbankaccountpost"></a>
# **TeamMembersIdTeamBillingBankAccountPost**
> Billing TeamMembersIdTeamBillingBankAccountPost (string id, TeamMember data = null)

Create Team Billing BankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingBankAccountPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Create Team Billing BankAccount
                Billing result = apiInstance.TeamMembersIdTeamBillingBankAccountPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingBankAccountPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingbankaccountput"></a>
# **TeamMembersIdTeamBillingBankAccountPut**
> Billing TeamMembersIdTeamBillingBankAccountPut (string id, TeamMember data = null)

Update Team Billing BankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingBankAccountPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update Team Billing BankAccount
                Billing result = apiInstance.TeamMembersIdTeamBillingBankAccountPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingBankAccountPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingbankaccountverifypost"></a>
# **TeamMembersIdTeamBillingBankAccountVerifyPost**
> Billing TeamMembersIdTeamBillingBankAccountVerifyPost (string id, TeamMember data = null)

Create Team Billing BankAccount

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingBankAccountVerifyPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Create Team Billing BankAccount
                Billing result = apiInstance.TeamMembersIdTeamBillingBankAccountVerifyPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingBankAccountVerifyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingcachedget"></a>
# **TeamMembersIdTeamBillingCachedGet**
> Billing TeamMembersIdTeamBillingCachedGet (string id)

Get Cached version of Team Billing

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingCachedGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Get Cached version of Team Billing
                Billing result = apiInstance.TeamMembersIdTeamBillingCachedGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingCachedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingcarddelete"></a>
# **TeamMembersIdTeamBillingCardDelete**
> Billing TeamMembersIdTeamBillingCardDelete (string id)

Delete Team Billing Card

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingCardDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Delete Team Billing Card
                Billing result = apiInstance.TeamMembersIdTeamBillingCardDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingCardDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingcardpost"></a>
# **TeamMembersIdTeamBillingCardPost**
> Billing TeamMembersIdTeamBillingCardPost (string id, TeamMember data = null)

Create Team Billing Card

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingCardPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Create Team Billing Card
                Billing result = apiInstance.TeamMembersIdTeamBillingCardPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingCardPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingcardput"></a>
# **TeamMembersIdTeamBillingCardPut**
> Billing TeamMembersIdTeamBillingCardPut (string id, TeamMember data = null)

Update Team Billing Card

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingCardPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update Team Billing Card
                Billing result = apiInstance.TeamMembersIdTeamBillingCardPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingCardPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillinginvoicesfkpost"></a>
# **TeamMembersIdTeamBillingInvoicesFkPost**
> BillingInvoice TeamMembersIdTeamBillingInvoicesFkPost (string id, string fk)

Pay Team Billing Invoice

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingInvoicesFkPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Billing Invoice id

            try
            {
                // Pay Team Billing Invoice
                BillingInvoice result = apiInstance.TeamMembersIdTeamBillingInvoicesFkPost(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingInvoicesFkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Billing Invoice id | 

### Return type

[**BillingInvoice**](BillingInvoice.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillinginvoicesget"></a>
# **TeamMembersIdTeamBillingInvoicesGet**
> List<BillingInvoice> TeamMembersIdTeamBillingInvoicesGet (string id, string filter = null)

List Team Billing Invoices

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingInvoicesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // List Team Billing Invoices
                List&lt;BillingInvoice&gt; result = apiInstance.TeamMembersIdTeamBillingInvoicesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingInvoicesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<BillingInvoice>**](BillingInvoice.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillinginvoicesupcomingget"></a>
# **TeamMembersIdTeamBillingInvoicesUpcomingGet**
> BillingInvoice TeamMembersIdTeamBillingInvoicesUpcomingGet (string id)

List Upcoming Team Billing Invoices

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingInvoicesUpcomingGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // List Upcoming Team Billing Invoices
                BillingInvoice result = apiInstance.TeamMembersIdTeamBillingInvoicesUpcomingGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingInvoicesUpcomingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**BillingInvoice**](BillingInvoice.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillinglimitlimitincreasepost"></a>
# **TeamMembersIdTeamBillingLimitLimitIncreasePost**
> Object TeamMembersIdTeamBillingLimitLimitIncreasePost (string id, string limit, BillingLimitLog data = null)

Increase Team Billing Limit by Limit

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingLimitLimitIncreasePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var limit = limit_example;  // string | Limit name
            var data = new BillingLimitLog(); // BillingLimitLog |  (optional) 

            try
            {
                // Increase Team Billing Limit by Limit
                Object result = apiInstance.TeamMembersIdTeamBillingLimitLimitIncreasePost(id, limit, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingLimitLimitIncreasePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **limit** | **string**| Limit name | 
 **data** | [**BillingLimitLog**](BillingLimitLog.md)|  | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillinglimitlimitincreasevalueget"></a>
# **TeamMembersIdTeamBillingLimitLimitIncreaseValueGet**
> InlineResponse2005 TeamMembersIdTeamBillingLimitLimitIncreaseValueGet (string id, string limit, string value)

Check if Team Billing Limit can be increased by Limit

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingLimitLimitIncreaseValueGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var limit = limit_example;  // string | Limit name
            var value = value_example;  // string | Value

            try
            {
                // Check if Team Billing Limit can be increased by Limit
                InlineResponse2005 result = apiInstance.TeamMembersIdTeamBillingLimitLimitIncreaseValueGet(id, limit, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingLimitLimitIncreaseValueGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **limit** | **string**| Limit name | 
 **value** | **string**| Value | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingput"></a>
# **TeamMembersIdTeamBillingPut**
> Billing TeamMembersIdTeamBillingPut (string id, TeamMember data = null)

Update Team Billing

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update Team Billing
                Billing result = apiInstance.TeamMembersIdTeamBillingPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingsourcedelete"></a>
# **TeamMembersIdTeamBillingSourceDelete**
> Billing TeamMembersIdTeamBillingSourceDelete (string id)

Delete Team Billing Source

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingSourceDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Delete Team Billing Source
                Billing result = apiInstance.TeamMembersIdTeamBillingSourceDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingSourceDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingsourcepost"></a>
# **TeamMembersIdTeamBillingSourcePost**
> Billing TeamMembersIdTeamBillingSourcePost (string id, TeamMember data = null)

Create Team Billing Source

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingSourcePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Create Team Billing Source
                Billing result = apiInstance.TeamMembersIdTeamBillingSourcePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingSourcePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingsourceput"></a>
# **TeamMembersIdTeamBillingSourcePut**
> Billing TeamMembersIdTeamBillingSourcePut (string id, TeamMember data = null)

Update Team Billing Source

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingSourcePutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update Team Billing Source
                Billing result = apiInstance.TeamMembersIdTeamBillingSourcePut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingSourcePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingsubscriptionplanput"></a>
# **TeamMembersIdTeamBillingSubscriptionPlanPut**
> Billing TeamMembersIdTeamBillingSubscriptionPlanPut (string id, TeamMember data = null)

Update Team Billing Subscription Plan

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingSubscriptionPlanPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update Team Billing Subscription Plan
                Billing result = apiInstance.TeamMembersIdTeamBillingSubscriptionPlanPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingSubscriptionPlanPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillingtaxevidenceget"></a>
# **TeamMembersIdTeamBillingTaxEvidenceGet**
> Object TeamMembersIdTeamBillingTaxEvidenceGet (string id)

Get Team Billing Tax Evidence

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingTaxEvidenceGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Get Team Billing Tax Evidence
                Object result = apiInstance.TeamMembersIdTeamBillingTaxEvidenceGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingTaxEvidenceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambillinguncachedget"></a>
# **TeamMembersIdTeamBillingUncachedGet**
> Billing TeamMembersIdTeamBillingUncachedGet (string id)

Get Team Billing

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBillingUncachedGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Get Team Billing
                Billing result = apiInstance.TeamMembersIdTeamBillingUncachedGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBillingUncachedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambranddelete"></a>
# **TeamMembersIdTeamBrandDelete**
> void TeamMembersIdTeamBrandDelete (string id)

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
    public class TeamMembersIdTeamBrandDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes brand of this model.
                apiInstance.TeamMembersIdTeamBrandDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBrandDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambrandget"></a>
# **TeamMembersIdTeamBrandGet**
> TeamBrand TeamMembersIdTeamBrandGet (string id, bool? refresh = null)

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
    public class TeamMembersIdTeamBrandGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation brand.
                TeamBrand result = apiInstance.TeamMembersIdTeamBrandGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBrandGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambrandpost"></a>
# **TeamMembersIdTeamBrandPost**
> TeamBrand TeamMembersIdTeamBrandPost (string id, TeamBrand data = null)

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
    public class TeamMembersIdTeamBrandPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamBrand(); // TeamBrand |  (optional) 

            try
            {
                // Creates a new instance in brand of this model.
                TeamBrand result = apiInstance.TeamMembersIdTeamBrandPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBrandPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamBrand**](TeamBrand.md)|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambrandput"></a>
# **TeamMembersIdTeamBrandPut**
> TeamBrand TeamMembersIdTeamBrandPut (string id, TeamBrand data = null)

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
    public class TeamMembersIdTeamBrandPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamBrand(); // TeamBrand |  (optional) 

            try
            {
                // Update brand of this model.
                TeamBrand result = apiInstance.TeamMembersIdTeamBrandPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBrandPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamBrand**](TeamBrand.md)|  | [optional] 

### Return type

[**TeamBrand**](TeamBrand.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigscountget"></a>
# **TeamMembersIdTeamBuilderConfigsCountGet**
> InlineResponse2001 TeamMembersIdTeamBuilderConfigsCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamBuilderConfigsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts builderConfigs of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamBuilderConfigsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigsdefaultget"></a>
# **TeamMembersIdTeamBuilderConfigsDefaultGet**
> TeamBuilderConfig TeamMembersIdTeamBuilderConfigsDefaultGet (string id)

Get default Team Builder Config

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBuilderConfigsDefaultGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Get default Team Builder Config
                TeamBuilderConfig result = apiInstance.TeamMembersIdTeamBuilderConfigsDefaultGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsDefaultGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigsdefaultproductsizematerialget"></a>
# **TeamMembersIdTeamBuilderConfigsDefaultProductSizeMaterialGet**
> List<ProductSizeMaterial> TeamMembersIdTeamBuilderConfigsDefaultProductSizeMaterialGet (string id)

Get default Team Builder Config Product Size Materials

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBuilderConfigsDefaultProductSizeMaterialGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Get default Team Builder Config Product Size Materials
                List&lt;ProductSizeMaterial&gt; result = apiInstance.TeamMembersIdTeamBuilderConfigsDefaultProductSizeMaterialGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsDefaultProductSizeMaterialGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**List<ProductSizeMaterial>**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigsdelete"></a>
# **TeamMembersIdTeamBuilderConfigsDelete**
> void TeamMembersIdTeamBuilderConfigsDelete (string id)

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
    public class TeamMembersIdTeamBuilderConfigsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all builderConfigs of this model.
                apiInstance.TeamMembersIdTeamBuilderConfigsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigsfkdelete"></a>
# **TeamMembersIdTeamBuilderConfigsFkDelete**
> void TeamMembersIdTeamBuilderConfigsFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamBuilderConfigsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for builderConfigs

            try
            {
                // Delete a related item by id for builderConfigs.
                apiInstance.TeamMembersIdTeamBuilderConfigsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for builderConfigs | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigsfkget"></a>
# **TeamMembersIdTeamBuilderConfigsFkGet**
> TeamBuilderConfig TeamMembersIdTeamBuilderConfigsFkGet (string id, string fk)

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
    public class TeamMembersIdTeamBuilderConfigsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for builderConfigs

            try
            {
                // Find a related item by id for builderConfigs.
                TeamBuilderConfig result = apiInstance.TeamMembersIdTeamBuilderConfigsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for builderConfigs | 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigsfklogoput"></a>
# **TeamMembersIdTeamBuilderConfigsFkLogoPut**
> TeamBuilderConfig TeamMembersIdTeamBuilderConfigsFkLogoPut (string id, string fk, TeamMember data)

Change Builder Config logo

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBuilderConfigsFkLogoPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | BuilderConfig id
            var data = new TeamMember(); // TeamMember | Logo

            try
            {
                // Change Builder Config logo
                TeamBuilderConfig result = apiInstance.TeamMembersIdTeamBuilderConfigsFkLogoPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsFkLogoPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| BuilderConfig id | 
 **data** | [**TeamMember**](TeamMember.md)| Logo | 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigsfkput"></a>
# **TeamMembersIdTeamBuilderConfigsFkPut**
> TeamBuilderConfig TeamMembersIdTeamBuilderConfigsFkPut (string id, string fk, TeamBuilderConfig data = null)

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
    public class TeamMembersIdTeamBuilderConfigsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for builderConfigs
            var data = new TeamBuilderConfig(); // TeamBuilderConfig |  (optional) 

            try
            {
                // Update a related item by id for builderConfigs.
                TeamBuilderConfig result = apiInstance.TeamMembersIdTeamBuilderConfigsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteambuilderconfigsfkwatermarkput"></a>
# **TeamMembersIdTeamBuilderConfigsFkWatermarkPut**
> TeamBuilderConfig TeamMembersIdTeamBuilderConfigsFkWatermarkPut (string id, string fk, TeamMember data)

Change Builder Config watermark

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamBuilderConfigsFkWatermarkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | BuilderConfig id
            var data = new TeamMember(); // TeamMember | Watermark

            try
            {
                // Change Builder Config watermark
                TeamBuilderConfig result = apiInstance.TeamMembersIdTeamBuilderConfigsFkWatermarkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsFkWatermarkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| BuilderConfig id | 
 **data** | [**TeamMember**](TeamMember.md)| Watermark | 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigsget"></a>
# **TeamMembersIdTeamBuilderConfigsGet**
> List<TeamBuilderConfig> TeamMembersIdTeamBuilderConfigsGet (string id, string filter = null)

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
    public class TeamMembersIdTeamBuilderConfigsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries builderConfigs of Team.
                List&lt;TeamBuilderConfig&gt; result = apiInstance.TeamMembersIdTeamBuilderConfigsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamBuilderConfig>**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteambuilderconfigspost"></a>
# **TeamMembersIdTeamBuilderConfigsPost**
> TeamBuilderConfig TeamMembersIdTeamBuilderConfigsPost (string id, TeamBuilderConfig data = null)

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
    public class TeamMembersIdTeamBuilderConfigsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamBuilderConfig(); // TeamBuilderConfig |  (optional) 

            try
            {
                // Creates a new instance in builderConfigs of this model.
                TeamBuilderConfig result = apiInstance.TeamMembersIdTeamBuilderConfigsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamBuilderConfigsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)|  | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatarecordget"></a>
# **TeamMembersIdTeamDataRecordGet**
> Object TeamMembersIdTeamDataRecordGet (string id)

Get TeamData Record

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamDataRecordGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Get TeamData Record
                Object result = apiInstance.TeamMembersIdTeamDataRecordGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataRecordGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatarecordpost"></a>
# **TeamMembersIdTeamDataRecordPost**
> Object TeamMembersIdTeamDataRecordPost (string id, TeamMember data = null)

Create TeamData Record

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamDataRecordPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember | Model instance data (optional) 

            try
            {
                // Create TeamData Record
                Object result = apiInstance.TeamMembersIdTeamDataRecordPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataRecordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)| Model instance data | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatarecordput"></a>
# **TeamMembersIdTeamDataRecordPut**
> Object TeamMembersIdTeamDataRecordPut (string id, TeamMember data = null)

Update TeamData Record

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamDataRecordPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember | Model instance data (optional) 

            try
            {
                // Update TeamData Record
                Object result = apiInstance.TeamMembersIdTeamDataRecordPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataRecordPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)| Model instance data | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatasourcescountget"></a>
# **TeamMembersIdTeamDataSourcesCountGet**
> InlineResponse2001 TeamMembersIdTeamDataSourcesCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamDataSourcesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts dataSources of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamDataSourcesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataSourcesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatasourcesdelete"></a>
# **TeamMembersIdTeamDataSourcesDelete**
> void TeamMembersIdTeamDataSourcesDelete (string id)

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
    public class TeamMembersIdTeamDataSourcesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all dataSources of this model.
                apiInstance.TeamMembersIdTeamDataSourcesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataSourcesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatasourcesfkdelete"></a>
# **TeamMembersIdTeamDataSourcesFkDelete**
> void TeamMembersIdTeamDataSourcesFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamDataSourcesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for dataSources

            try
            {
                // Delete a related item by id for dataSources.
                apiInstance.TeamMembersIdTeamDataSourcesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataSourcesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for dataSources | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatasourcesfkget"></a>
# **TeamMembersIdTeamDataSourcesFkGet**
> DataSource TeamMembersIdTeamDataSourcesFkGet (string id, string fk)

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
    public class TeamMembersIdTeamDataSourcesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for dataSources

            try
            {
                // Find a related item by id for dataSources.
                DataSource result = apiInstance.TeamMembersIdTeamDataSourcesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataSourcesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for dataSources | 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatasourcesfkput"></a>
# **TeamMembersIdTeamDataSourcesFkPut**
> DataSource TeamMembersIdTeamDataSourcesFkPut (string id, string fk, DataSource data = null)

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
    public class TeamMembersIdTeamDataSourcesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for dataSources
            var data = new DataSource(); // DataSource |  (optional) 

            try
            {
                // Update a related item by id for dataSources.
                DataSource result = apiInstance.TeamMembersIdTeamDataSourcesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataSourcesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamdatasourcesget"></a>
# **TeamMembersIdTeamDataSourcesGet**
> List<DataSource> TeamMembersIdTeamDataSourcesGet (string id, string filter = null)

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
    public class TeamMembersIdTeamDataSourcesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries dataSources of Team.
                List&lt;DataSource&gt; result = apiInstance.TeamMembersIdTeamDataSourcesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataSourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DataSource>**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdatasourcespost"></a>
# **TeamMembersIdTeamDataSourcesPost**
> DataSource TeamMembersIdTeamDataSourcesPost (string id, DataSource data = null)

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
    public class TeamMembersIdTeamDataSourcesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new DataSource(); // DataSource |  (optional) 

            try
            {
                // Creates a new instance in dataSources of this model.
                DataSource result = apiInstance.TeamMembersIdTeamDataSourcesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDataSourcesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**DataSource**](DataSource.md)|  | [optional] 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdynamicdatascountget"></a>
# **TeamMembersIdTeamDynamicDatasCountGet**
> InlineResponse2001 TeamMembersIdTeamDynamicDatasCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamDynamicDatasCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts dynamicDatas of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamDynamicDatasCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDynamicDatasCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdynamicdatasdelete"></a>
# **TeamMembersIdTeamDynamicDatasDelete**
> void TeamMembersIdTeamDynamicDatasDelete (string id)

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
    public class TeamMembersIdTeamDynamicDatasDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all dynamicDatas of this model.
                apiInstance.TeamMembersIdTeamDynamicDatasDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDynamicDatasDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdynamicdatasfkdelete"></a>
# **TeamMembersIdTeamDynamicDatasFkDelete**
> void TeamMembersIdTeamDynamicDatasFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamDynamicDatasFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Delete a related item by id for dynamicDatas.
                apiInstance.TeamMembersIdTeamDynamicDatasFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDynamicDatasFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdynamicdatasfkget"></a>
# **TeamMembersIdTeamDynamicDatasFkGet**
> DynamicData TeamMembersIdTeamDynamicDatasFkGet (string id, string fk)

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
    public class TeamMembersIdTeamDynamicDatasFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Find a related item by id for dynamicDatas.
                DynamicData result = apiInstance.TeamMembersIdTeamDynamicDatasFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDynamicDatasFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdynamicdatasfkput"></a>
# **TeamMembersIdTeamDynamicDatasFkPut**
> DynamicData TeamMembersIdTeamDynamicDatasFkPut (string id, string fk, DynamicData data = null)

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
    public class TeamMembersIdTeamDynamicDatasFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for dynamicDatas
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Update a related item by id for dynamicDatas.
                DynamicData result = apiInstance.TeamMembersIdTeamDynamicDatasFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDynamicDatasFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamdynamicdatasget"></a>
# **TeamMembersIdTeamDynamicDatasGet**
> List<DynamicData> TeamMembersIdTeamDynamicDatasGet (string id, string filter = null)

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
    public class TeamMembersIdTeamDynamicDatasGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries dynamicDatas of Team.
                List&lt;DynamicData&gt; result = apiInstance.TeamMembersIdTeamDynamicDatasGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDynamicDatasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DynamicData>**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamdynamicdataspost"></a>
# **TeamMembersIdTeamDynamicDatasPost**
> DynamicData TeamMembersIdTeamDynamicDatasPost (string id, DynamicData data = null)

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
    public class TeamMembersIdTeamDynamicDatasPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Creates a new instance in dynamicDatas of this model.
                DynamicData result = apiInstance.TeamMembersIdTeamDynamicDatasPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamDynamicDatasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**DynamicData**](DynamicData.md)|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamget"></a>
# **TeamMembersIdTeamGet**
> Team TeamMembersIdTeamGet (string id, bool? refresh = null)

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
    public class TeamMembersIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamMembersIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagefolderscountget"></a>
# **TeamMembersIdTeamImageFoldersCountGet**
> InlineResponse2001 TeamMembersIdTeamImageFoldersCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamImageFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts imageFolders of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamImageFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImageFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagefoldersdelete"></a>
# **TeamMembersIdTeamImageFoldersDelete**
> void TeamMembersIdTeamImageFoldersDelete (string id)

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
    public class TeamMembersIdTeamImageFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all imageFolders of this model.
                apiInstance.TeamMembersIdTeamImageFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImageFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagefoldersfkdelete"></a>
# **TeamMembersIdTeamImageFoldersFkDelete**
> void TeamMembersIdTeamImageFoldersFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamImageFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Delete a related item by id for imageFolders.
                apiInstance.TeamMembersIdTeamImageFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImageFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagefoldersfkget"></a>
# **TeamMembersIdTeamImageFoldersFkGet**
> ImageFolder TeamMembersIdTeamImageFoldersFkGet (string id, string fk)

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
    public class TeamMembersIdTeamImageFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Find a related item by id for imageFolders.
                ImageFolder result = apiInstance.TeamMembersIdTeamImageFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImageFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagefoldersfkput"></a>
# **TeamMembersIdTeamImageFoldersFkPut**
> ImageFolder TeamMembersIdTeamImageFoldersFkPut (string id, string fk, ImageFolder data = null)

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
    public class TeamMembersIdTeamImageFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Update a related item by id for imageFolders.
                ImageFolder result = apiInstance.TeamMembersIdTeamImageFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImageFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamimagefoldersget"></a>
# **TeamMembersIdTeamImageFoldersGet**
> List<ImageFolder> TeamMembersIdTeamImageFoldersGet (string id, string filter = null)

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
    public class TeamMembersIdTeamImageFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries imageFolders of Team.
                List&lt;ImageFolder&gt; result = apiInstance.TeamMembersIdTeamImageFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImageFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ImageFolder>**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagefolderspost"></a>
# **TeamMembersIdTeamImageFoldersPost**
> ImageFolder TeamMembersIdTeamImageFoldersPost (string id, ImageFolder data = null)

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
    public class TeamMembersIdTeamImageFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Creates a new instance in imageFolders of this model.
                ImageFolder result = apiInstance.TeamMembersIdTeamImageFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImageFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagescountget"></a>
# **TeamMembersIdTeamImagesCountGet**
> InlineResponse2001 TeamMembersIdTeamImagesCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamImagesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts images of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamImagesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImagesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagesdelete"></a>
# **TeamMembersIdTeamImagesDelete**
> void TeamMembersIdTeamImagesDelete (string id)

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
    public class TeamMembersIdTeamImagesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all images of this model.
                apiInstance.TeamMembersIdTeamImagesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImagesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagesfkdelete"></a>
# **TeamMembersIdTeamImagesFkDelete**
> void TeamMembersIdTeamImagesFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamImagesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for images

            try
            {
                // Delete a related item by id for images.
                apiInstance.TeamMembersIdTeamImagesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImagesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for images | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagesfkget"></a>
# **TeamMembersIdTeamImagesFkGet**
> Image TeamMembersIdTeamImagesFkGet (string id, string fk)

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
    public class TeamMembersIdTeamImagesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for images

            try
            {
                // Find a related item by id for images.
                Image result = apiInstance.TeamMembersIdTeamImagesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImagesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for images | 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagesfkput"></a>
# **TeamMembersIdTeamImagesFkPut**
> Image TeamMembersIdTeamImagesFkPut (string id, string fk, Image data = null)

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
    public class TeamMembersIdTeamImagesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for images
            var data = new Image(); // Image |  (optional) 

            try
            {
                // Update a related item by id for images.
                Image result = apiInstance.TeamMembersIdTeamImagesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImagesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamimagesget"></a>
# **TeamMembersIdTeamImagesGet**
> List<Image> TeamMembersIdTeamImagesGet (string id, string filter = null)

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
    public class TeamMembersIdTeamImagesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries images of Team.
                List&lt;Image&gt; result = apiInstance.TeamMembersIdTeamImagesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Image>**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamimagespost"></a>
# **TeamMembersIdTeamImagesPost**
> Image TeamMembersIdTeamImagesPost (string id, Image data = null)

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
    public class TeamMembersIdTeamImagesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Image(); // Image |  (optional) 

            try
            {
                // Creates a new instance in images of this model.
                Image result = apiInstance.TeamMembersIdTeamImagesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamImagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Image**](Image.md)|  | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamlogoput"></a>
# **TeamMembersIdTeamLogoPut**
> Team TeamMembersIdTeamLogoPut (string id, string id2, TeamMember data)

Change Team logo

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamLogoPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember | Logo

            try
            {
                // Change Team logo
                Team result = apiInstance.TeamMembersIdTeamLogoPut(id, id2, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamLogoPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)| Logo | 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammemberscountget"></a>
# **TeamMembersIdTeamMembersCountGet**
> InlineResponse2001 TeamMembersIdTeamMembersCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts members of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamMembersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammembersdelete"></a>
# **TeamMembersIdTeamMembersDelete**
> void TeamMembersIdTeamMembersDelete (string id)

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
    public class TeamMembersIdTeamMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all members of this model.
                apiInstance.TeamMembersIdTeamMembersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammembersfkdelete"></a>
# **TeamMembersIdTeamMembersFkDelete**
> void TeamMembersIdTeamMembersFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Delete a related item by id for members.
                apiInstance.TeamMembersIdTeamMembersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammembersfkget"></a>
# **TeamMembersIdTeamMembersFkGet**
> Customer TeamMembersIdTeamMembersFkGet (string id, string fk)

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
    public class TeamMembersIdTeamMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Find a related item by id for members.
                Customer result = apiInstance.TeamMembersIdTeamMembersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for members | 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammembersfkput"></a>
# **TeamMembersIdTeamMembersFkPut**
> Customer TeamMembersIdTeamMembersFkPut (string id, string fk, Customer data = null)

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
    public class TeamMembersIdTeamMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for members
            var data = new Customer(); // Customer |  (optional) 

            try
            {
                // Update a related item by id for members.
                Customer result = apiInstance.TeamMembersIdTeamMembersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteammembersget"></a>
# **TeamMembersIdTeamMembersGet**
> List<Customer> TeamMembersIdTeamMembersGet (string id, string filter = null)

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
    public class TeamMembersIdTeamMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries members of Team.
                List&lt;Customer&gt; result = apiInstance.TeamMembersIdTeamMembersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Customer>**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammemberspost"></a>
# **TeamMembersIdTeamMembersPost**
> Customer TeamMembersIdTeamMembersPost (string id, Customer data = null)

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
    public class TeamMembersIdTeamMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Customer(); // Customer |  (optional) 

            try
            {
                // Creates a new instance in members of this model.
                Customer result = apiInstance.TeamMembersIdTeamMembersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Customer**](Customer.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammembersrelfkdelete"></a>
# **TeamMembersIdTeamMembersRelFkDelete**
> void TeamMembersIdTeamMembersRelFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamMembersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Remove the members relation to an item by id.
                apiInstance.TeamMembersIdTeamMembersRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammembersrelfkhead"></a>
# **TeamMembersIdTeamMembersRelFkHead**
> bool? TeamMembersIdTeamMembersRelFkHead (string id, string fk)

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
    public class TeamMembersIdTeamMembersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Check the existence of members relation to an item by id.
                bool? result = apiInstance.TeamMembersIdTeamMembersRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for members | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteammembersrelfkput"></a>
# **TeamMembersIdTeamMembersRelFkPut**
> TeamMember TeamMembersIdTeamMembersRelFkPut (string id, string fk, TeamMember data = null)

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
    public class TeamMembersIdTeamMembersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for members
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Add a related item by id for members.
                TeamMember result = apiInstance.TeamMembersIdTeamMembersRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamMembersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteampermissiondelete"></a>
# **TeamMembersIdTeamPermissionDelete**
> void TeamMembersIdTeamPermissionDelete (string id)

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
    public class TeamMembersIdTeamPermissionDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes permission of this model.
                apiInstance.TeamMembersIdTeamPermissionDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPermissionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteampermissionget"></a>
# **TeamMembersIdTeamPermissionGet**
> TeamPermissionSet TeamMembersIdTeamPermissionGet (string id, bool? refresh = null)

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
    public class TeamMembersIdTeamPermissionGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation permission.
                TeamPermissionSet result = apiInstance.TeamMembersIdTeamPermissionGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPermissionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteampermissionpost"></a>
# **TeamMembersIdTeamPermissionPost**
> TeamPermissionSet TeamMembersIdTeamPermissionPost (string id, TeamPermissionSet data = null)

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
    public class TeamMembersIdTeamPermissionPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamPermissionSet(); // TeamPermissionSet |  (optional) 

            try
            {
                // Creates a new instance in permission of this model.
                TeamPermissionSet result = apiInstance.TeamMembersIdTeamPermissionPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPermissionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteampermissionput"></a>
# **TeamMembersIdTeamPermissionPut**
> TeamPermissionSet TeamMembersIdTeamPermissionPut (string id, TeamPermissionSet data = null)

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
    public class TeamMembersIdTeamPermissionPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamPermissionSet(); // TeamPermissionSet |  (optional) 

            try
            {
                // Update permission of this model.
                TeamPermissionSet result = apiInstance.TeamMembersIdTeamPermissionPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPermissionPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)|  | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamportalscountget"></a>
# **TeamMembersIdTeamPortalsCountGet**
> InlineResponse2001 TeamMembersIdTeamPortalsCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamPortalsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portals of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamPortalsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPortalsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamportalsdelete"></a>
# **TeamMembersIdTeamPortalsDelete**
> void TeamMembersIdTeamPortalsDelete (string id)

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
    public class TeamMembersIdTeamPortalsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all portals of this model.
                apiInstance.TeamMembersIdTeamPortalsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPortalsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamportalsfkdelete"></a>
# **TeamMembersIdTeamPortalsFkDelete**
> void TeamMembersIdTeamPortalsFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamPortalsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Delete a related item by id for portals.
                apiInstance.TeamMembersIdTeamPortalsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPortalsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for portals | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamportalsfkget"></a>
# **TeamMembersIdTeamPortalsFkGet**
> Portal TeamMembersIdTeamPortalsFkGet (string id, string fk)

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
    public class TeamMembersIdTeamPortalsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals

            try
            {
                // Find a related item by id for portals.
                Portal result = apiInstance.TeamMembersIdTeamPortalsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPortalsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for portals | 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamportalsfkput"></a>
# **TeamMembersIdTeamPortalsFkPut**
> Portal TeamMembersIdTeamPortalsFkPut (string id, string fk, Portal data = null)

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
    public class TeamMembersIdTeamPortalsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for portals
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Update a related item by id for portals.
                Portal result = apiInstance.TeamMembersIdTeamPortalsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPortalsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamportalsget"></a>
# **TeamMembersIdTeamPortalsGet**
> List<Portal> TeamMembersIdTeamPortalsGet (string id, string filter = null)

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
    public class TeamMembersIdTeamPortalsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portals of Team.
                List&lt;Portal&gt; result = apiInstance.TeamMembersIdTeamPortalsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPortalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Portal>**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamportalspost"></a>
# **TeamMembersIdTeamPortalsPost**
> Portal TeamMembersIdTeamPortalsPost (string id, Portal data = null)

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
    public class TeamMembersIdTeamPortalsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Creates a new instance in portals of this model.
                Portal result = apiInstance.TeamMembersIdTeamPortalsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamPortalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Portal**](Portal.md)|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductmaterialscountget"></a>
# **TeamMembersIdTeamProductMaterialsCountGet**
> InlineResponse2001 TeamMembersIdTeamProductMaterialsCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamProductMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productMaterials of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamProductMaterialsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductmaterialsdelete"></a>
# **TeamMembersIdTeamProductMaterialsDelete**
> void TeamMembersIdTeamProductMaterialsDelete (string id)

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
    public class TeamMembersIdTeamProductMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all productMaterials of this model.
                apiInstance.TeamMembersIdTeamProductMaterialsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductmaterialsfkdelete"></a>
# **TeamMembersIdTeamProductMaterialsFkDelete**
> void TeamMembersIdTeamProductMaterialsFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamProductMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productMaterials

            try
            {
                // Delete a related item by id for productMaterials.
                apiInstance.TeamMembersIdTeamProductMaterialsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for productMaterials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductmaterialsfkget"></a>
# **TeamMembersIdTeamProductMaterialsFkGet**
> ProductMaterial TeamMembersIdTeamProductMaterialsFkGet (string id, string fk)

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
    public class TeamMembersIdTeamProductMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productMaterials

            try
            {
                // Find a related item by id for productMaterials.
                ProductMaterial result = apiInstance.TeamMembersIdTeamProductMaterialsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for productMaterials | 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductmaterialsfkput"></a>
# **TeamMembersIdTeamProductMaterialsFkPut**
> ProductMaterial TeamMembersIdTeamProductMaterialsFkPut (string id, string fk, ProductMaterial data = null)

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
    public class TeamMembersIdTeamProductMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productMaterials
            var data = new ProductMaterial(); // ProductMaterial |  (optional) 

            try
            {
                // Update a related item by id for productMaterials.
                ProductMaterial result = apiInstance.TeamMembersIdTeamProductMaterialsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamproductmaterialsget"></a>
# **TeamMembersIdTeamProductMaterialsGet**
> List<ProductMaterial> TeamMembersIdTeamProductMaterialsGet (string id, string filter = null)

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
    public class TeamMembersIdTeamProductMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productMaterials of Team.
                List&lt;ProductMaterial&gt; result = apiInstance.TeamMembersIdTeamProductMaterialsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductMaterial>**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductmaterialspost"></a>
# **TeamMembersIdTeamProductMaterialsPost**
> ProductMaterial TeamMembersIdTeamProductMaterialsPost (string id, ProductMaterial data = null)

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
    public class TeamMembersIdTeamProductMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new ProductMaterial(); // ProductMaterial |  (optional) 

            try
            {
                // Creates a new instance in productMaterials of this model.
                ProductMaterial result = apiInstance.TeamMembersIdTeamProductMaterialsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**ProductMaterial**](ProductMaterial.md)|  | [optional] 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductpdfcolorprofilesavailableget"></a>
# **TeamMembersIdTeamProductPdfColorProfilesAvailableGet**
> List<ProductPdfColorProfile> TeamMembersIdTeamProductPdfColorProfilesAvailableGet (string id, string filter = null)

Find all available PdfColorProfile

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamProductPdfColorProfilesAvailableGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all available PdfColorProfile
                List&lt;ProductPdfColorProfile&gt; result = apiInstance.TeamMembersIdTeamProductPdfColorProfilesAvailableGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductPdfColorProfilesAvailableGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<ProductPdfColorProfile>**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductpdfcolorprofilescountget"></a>
# **TeamMembersIdTeamProductPdfColorProfilesCountGet**
> InlineResponse2001 TeamMembersIdTeamProductPdfColorProfilesCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamProductPdfColorProfilesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productPdfColorProfiles of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamProductPdfColorProfilesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductPdfColorProfilesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductpdfcolorprofilesdelete"></a>
# **TeamMembersIdTeamProductPdfColorProfilesDelete**
> void TeamMembersIdTeamProductPdfColorProfilesDelete (string id)

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
    public class TeamMembersIdTeamProductPdfColorProfilesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all productPdfColorProfiles of this model.
                apiInstance.TeamMembersIdTeamProductPdfColorProfilesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductPdfColorProfilesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductpdfcolorprofilesfkdelete"></a>
# **TeamMembersIdTeamProductPdfColorProfilesFkDelete**
> void TeamMembersIdTeamProductPdfColorProfilesFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamProductPdfColorProfilesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productPdfColorProfiles

            try
            {
                // Delete a related item by id for productPdfColorProfiles.
                apiInstance.TeamMembersIdTeamProductPdfColorProfilesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductPdfColorProfilesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for productPdfColorProfiles | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductpdfcolorprofilesfkget"></a>
# **TeamMembersIdTeamProductPdfColorProfilesFkGet**
> ProductPdfColorProfile TeamMembersIdTeamProductPdfColorProfilesFkGet (string id, string fk)

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
    public class TeamMembersIdTeamProductPdfColorProfilesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productPdfColorProfiles

            try
            {
                // Find a related item by id for productPdfColorProfiles.
                ProductPdfColorProfile result = apiInstance.TeamMembersIdTeamProductPdfColorProfilesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductPdfColorProfilesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for productPdfColorProfiles | 

### Return type

[**ProductPdfColorProfile**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductpdfcolorprofilesfkput"></a>
# **TeamMembersIdTeamProductPdfColorProfilesFkPut**
> ProductPdfColorProfile TeamMembersIdTeamProductPdfColorProfilesFkPut (string id, string fk, ProductPdfColorProfile data = null)

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
    public class TeamMembersIdTeamProductPdfColorProfilesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productPdfColorProfiles
            var data = new ProductPdfColorProfile(); // ProductPdfColorProfile |  (optional) 

            try
            {
                // Update a related item by id for productPdfColorProfiles.
                ProductPdfColorProfile result = apiInstance.TeamMembersIdTeamProductPdfColorProfilesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductPdfColorProfilesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamproductpdfcolorprofilesget"></a>
# **TeamMembersIdTeamProductPdfColorProfilesGet**
> List<ProductPdfColorProfile> TeamMembersIdTeamProductPdfColorProfilesGet (string id, string filter = null)

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
    public class TeamMembersIdTeamProductPdfColorProfilesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productPdfColorProfiles of Team.
                List&lt;ProductPdfColorProfile&gt; result = apiInstance.TeamMembersIdTeamProductPdfColorProfilesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductPdfColorProfilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductPdfColorProfile>**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductpdfcolorprofilesuploadpost"></a>
# **TeamMembersIdTeamProductPdfColorProfilesUploadPost**
> ProductPdfColorProfile TeamMembersIdTeamProductPdfColorProfilesUploadPost (string id)

Upload ICC PDF Color Profile for this Team

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamProductPdfColorProfilesUploadPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Upload ICC PDF Color Profile for this Team
                ProductPdfColorProfile result = apiInstance.TeamMembersIdTeamProductPdfColorProfilesUploadPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductPdfColorProfilesUploadPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

[**ProductPdfColorProfile**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductsizematerialscountget"></a>
# **TeamMembersIdTeamProductSizeMaterialsCountGet**
> InlineResponse2001 TeamMembersIdTeamProductSizeMaterialsCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamProductSizeMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productSizeMaterials of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamProductSizeMaterialsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductSizeMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductsizematerialsdelete"></a>
# **TeamMembersIdTeamProductSizeMaterialsDelete**
> void TeamMembersIdTeamProductSizeMaterialsDelete (string id)

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
    public class TeamMembersIdTeamProductSizeMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all productSizeMaterials of this model.
                apiInstance.TeamMembersIdTeamProductSizeMaterialsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductSizeMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductsizematerialsfkdelete"></a>
# **TeamMembersIdTeamProductSizeMaterialsFkDelete**
> void TeamMembersIdTeamProductSizeMaterialsFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamProductSizeMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials

            try
            {
                // Delete a related item by id for productSizeMaterials.
                apiInstance.TeamMembersIdTeamProductSizeMaterialsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductSizeMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for productSizeMaterials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductsizematerialsfkget"></a>
# **TeamMembersIdTeamProductSizeMaterialsFkGet**
> ProductSizeMaterial TeamMembersIdTeamProductSizeMaterialsFkGet (string id, string fk)

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
    public class TeamMembersIdTeamProductSizeMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials

            try
            {
                // Find a related item by id for productSizeMaterials.
                ProductSizeMaterial result = apiInstance.TeamMembersIdTeamProductSizeMaterialsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductSizeMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for productSizeMaterials | 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductsizematerialsfkput"></a>
# **TeamMembersIdTeamProductSizeMaterialsFkPut**
> ProductSizeMaterial TeamMembersIdTeamProductSizeMaterialsFkPut (string id, string fk, ProductSizeMaterial data = null)

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
    public class TeamMembersIdTeamProductSizeMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Update a related item by id for productSizeMaterials.
                ProductSizeMaterial result = apiInstance.TeamMembersIdTeamProductSizeMaterialsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductSizeMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamproductsizematerialsget"></a>
# **TeamMembersIdTeamProductSizeMaterialsGet**
> List<ProductSizeMaterial> TeamMembersIdTeamProductSizeMaterialsGet (string id, string filter = null)

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
    public class TeamMembersIdTeamProductSizeMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productSizeMaterials of Team.
                List&lt;ProductSizeMaterial&gt; result = apiInstance.TeamMembersIdTeamProductSizeMaterialsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductSizeMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductSizeMaterial>**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamproductsizematerialspost"></a>
# **TeamMembersIdTeamProductSizeMaterialsPost**
> ProductSizeMaterial TeamMembersIdTeamProductSizeMaterialsPost (string id, ProductSizeMaterial data = null)

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
    public class TeamMembersIdTeamProductSizeMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Creates a new instance in productSizeMaterials of this model.
                ProductSizeMaterial result = apiInstance.TeamMembersIdTeamProductSizeMaterialsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamProductSizeMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamteamdataget"></a>
# **TeamMembersIdTeamTeamDataGet**
> DynamicData TeamMembersIdTeamTeamDataGet (string id, bool? refresh = null)

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
    public class TeamMembersIdTeamTeamDataGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation teamData.
                DynamicData result = apiInstance.TeamMembersIdTeamTeamDataGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTeamDataGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamteammemberscountget"></a>
# **TeamMembersIdTeamTeamMembersCountGet**
> InlineResponse2001 TeamMembersIdTeamTeamMembersCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamTeamMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts teamMembers of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamTeamMembersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTeamMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamteammembersdelete"></a>
# **TeamMembersIdTeamTeamMembersDelete**
> void TeamMembersIdTeamTeamMembersDelete (string id)

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
    public class TeamMembersIdTeamTeamMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all teamMembers of this model.
                apiInstance.TeamMembersIdTeamTeamMembersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTeamMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamteammembersfkdelete"></a>
# **TeamMembersIdTeamTeamMembersFkDelete**
> void TeamMembersIdTeamTeamMembersFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamTeamMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for teamMembers

            try
            {
                // Delete a related item by id for teamMembers.
                apiInstance.TeamMembersIdTeamTeamMembersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTeamMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for teamMembers | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamteammembersfkget"></a>
# **TeamMembersIdTeamTeamMembersFkGet**
> TeamMember TeamMembersIdTeamTeamMembersFkGet (string id, string fk)

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
    public class TeamMembersIdTeamTeamMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for teamMembers

            try
            {
                // Find a related item by id for teamMembers.
                TeamMember result = apiInstance.TeamMembersIdTeamTeamMembersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTeamMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for teamMembers | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamteammembersfkput"></a>
# **TeamMembersIdTeamTeamMembersFkPut**
> TeamMember TeamMembersIdTeamTeamMembersFkPut (string id, string fk, TeamMember data = null)

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
    public class TeamMembersIdTeamTeamMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for teamMembers
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for teamMembers.
                TeamMember result = apiInstance.TeamMembersIdTeamTeamMembersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTeamMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamteammembersget"></a>
# **TeamMembersIdTeamTeamMembersGet**
> List<TeamMember> TeamMembersIdTeamTeamMembersGet (string id, string filter = null)

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
    public class TeamMembersIdTeamTeamMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries teamMembers of Team.
                List&lt;TeamMember&gt; result = apiInstance.TeamMembersIdTeamTeamMembersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTeamMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamteammemberspost"></a>
# **TeamMembersIdTeamTeamMembersPost**
> TeamMember TeamMembersIdTeamTeamMembersPost (string id, TeamMember data = null)

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
    public class TeamMembersIdTeamTeamMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in teamMembers of this model.
                TeamMember result = apiInstance.TeamMembersIdTeamTeamMembersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTeamMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatefolderscountget"></a>
# **TeamMembersIdTeamTemplateFoldersCountGet**
> InlineResponse2001 TeamMembersIdTeamTemplateFoldersCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamTemplateFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templateFolders of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamTemplateFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplateFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatefoldersdelete"></a>
# **TeamMembersIdTeamTemplateFoldersDelete**
> void TeamMembersIdTeamTemplateFoldersDelete (string id)

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
    public class TeamMembersIdTeamTemplateFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all templateFolders of this model.
                apiInstance.TeamMembersIdTeamTemplateFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplateFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatefoldersfkdelete"></a>
# **TeamMembersIdTeamTemplateFoldersFkDelete**
> void TeamMembersIdTeamTemplateFoldersFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamTemplateFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Delete a related item by id for templateFolders.
                apiInstance.TeamMembersIdTeamTemplateFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplateFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatefoldersfkget"></a>
# **TeamMembersIdTeamTemplateFoldersFkGet**
> TeamTemplateFolder TeamMembersIdTeamTemplateFoldersFkGet (string id, string fk)

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
    public class TeamMembersIdTeamTemplateFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Find a related item by id for templateFolders.
                TeamTemplateFolder result = apiInstance.TeamMembersIdTeamTemplateFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplateFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatefoldersfkput"></a>
# **TeamMembersIdTeamTemplateFoldersFkPut**
> TeamTemplateFolder TeamMembersIdTeamTemplateFoldersFkPut (string id, string fk, TeamTemplateFolder data = null)

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
    public class TeamMembersIdTeamTemplateFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templateFolders
            var data = new TeamTemplateFolder(); // TeamTemplateFolder |  (optional) 

            try
            {
                // Update a related item by id for templateFolders.
                TeamTemplateFolder result = apiInstance.TeamMembersIdTeamTemplateFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplateFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamtemplatefoldersget"></a>
# **TeamMembersIdTeamTemplateFoldersGet**
> List<TeamTemplateFolder> TeamMembersIdTeamTemplateFoldersGet (string id, string filter = null)

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
    public class TeamMembersIdTeamTemplateFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templateFolders of Team.
                List&lt;TeamTemplateFolder&gt; result = apiInstance.TeamMembersIdTeamTemplateFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplateFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamTemplateFolder>**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatefolderspost"></a>
# **TeamMembersIdTeamTemplateFoldersPost**
> TeamTemplateFolder TeamMembersIdTeamTemplateFoldersPost (string id, TeamTemplateFolder data = null)

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
    public class TeamMembersIdTeamTemplateFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new TeamTemplateFolder(); // TeamTemplateFolder |  (optional) 

            try
            {
                // Creates a new instance in templateFolders of this model.
                TeamTemplateFolder result = apiInstance.TeamMembersIdTeamTemplateFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplateFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)|  | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatescountget"></a>
# **TeamMembersIdTeamTemplatesCountGet**
> InlineResponse2001 TeamMembersIdTeamTemplatesCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamTemplatesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatesdelete"></a>
# **TeamMembersIdTeamTemplatesDelete**
> void TeamMembersIdTeamTemplatesDelete (string id)

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
    public class TeamMembersIdTeamTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all templates of this model.
                apiInstance.TeamMembersIdTeamTemplatesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatesfkdelete"></a>
# **TeamMembersIdTeamTemplatesFkDelete**
> void TeamMembersIdTeamTemplatesFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.TeamMembersIdTeamTemplatesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatesfkget"></a>
# **TeamMembersIdTeamTemplatesFkGet**
> Template TeamMembersIdTeamTemplatesFkGet (string id, string fk)

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
    public class TeamMembersIdTeamTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.TeamMembersIdTeamTemplatesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatesfkput"></a>
# **TeamMembersIdTeamTemplatesFkPut**
> Template TeamMembersIdTeamTemplatesFkPut (string id, string fk, Template data = null)

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
    public class TeamMembersIdTeamTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.TeamMembersIdTeamTemplatesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamtemplatesfkurlreviewget"></a>
# **TeamMembersIdTeamTemplatesFkUrlReviewGet**
> string TeamMembersIdTeamTemplatesFkUrlReviewGet (string id, string fk)

Get URL to review a Team Template

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamTemplatesFkUrlReviewGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Template id

            try
            {
                // Get URL to review a Team Template
                string result = apiInstance.TeamMembersIdTeamTemplatesFkUrlReviewGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesFkUrlReviewGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Template id | 

### Return type

**string**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatesget"></a>
# **TeamMembersIdTeamTemplatesGet**
> List<Template> TeamMembersIdTeamTemplatesGet (string id, string filter = null)

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
    public class TeamMembersIdTeamTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of Team.
                List&lt;Template&gt; result = apiInstance.TeamMembersIdTeamTemplatesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplatespost"></a>
# **TeamMembersIdTeamTemplatesPost**
> Template TeamMembersIdTeamTemplatesPost (string id, Template data = null)

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
    public class TeamMembersIdTeamTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.TeamMembersIdTeamTemplatesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamtemplateswithdesignsget"></a>
# **TeamMembersIdTeamTemplatesWithDesignsGet**
> List<Template> TeamMembersIdTeamTemplatesWithDesignsGet (string id, string id2, string filter = null)

List Templates with Designs for the Team of TeamMember

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTeamTemplatesWithDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // List Templates with Designs for the Team of TeamMember
                List&lt;Template&gt; result = apiInstance.TeamMembersIdTeamTemplatesWithDesignsGet(id, id2, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamTemplatesWithDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamworkflowscountget"></a>
# **TeamMembersIdTeamWorkflowsCountGet**
> InlineResponse2001 TeamMembersIdTeamWorkflowsCountGet (string id, string where = null)

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
    public class TeamMembersIdTeamWorkflowsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts workflows of Team.
                InlineResponse2001 result = apiInstance.TeamMembersIdTeamWorkflowsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamWorkflowsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamworkflowsdelete"></a>
# **TeamMembersIdTeamWorkflowsDelete**
> void TeamMembersIdTeamWorkflowsDelete (string id)

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
    public class TeamMembersIdTeamWorkflowsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all workflows of this model.
                apiInstance.TeamMembersIdTeamWorkflowsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamWorkflowsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamworkflowsfkdelete"></a>
# **TeamMembersIdTeamWorkflowsFkDelete**
> void TeamMembersIdTeamWorkflowsFkDelete (string id, string fk)

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
    public class TeamMembersIdTeamWorkflowsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for workflows

            try
            {
                // Delete a related item by id for workflows.
                apiInstance.TeamMembersIdTeamWorkflowsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamWorkflowsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for workflows | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamworkflowsfkget"></a>
# **TeamMembersIdTeamWorkflowsFkGet**
> Workflow TeamMembersIdTeamWorkflowsFkGet (string id, string fk)

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
    public class TeamMembersIdTeamWorkflowsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for workflows

            try
            {
                // Find a related item by id for workflows.
                Workflow result = apiInstance.TeamMembersIdTeamWorkflowsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamWorkflowsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for workflows | 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamworkflowsfkput"></a>
# **TeamMembersIdTeamWorkflowsFkPut**
> Workflow TeamMembersIdTeamWorkflowsFkPut (string id, string fk, Workflow data = null)

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
    public class TeamMembersIdTeamWorkflowsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for workflows
            var data = new Workflow(); // Workflow |  (optional) 

            try
            {
                // Update a related item by id for workflows.
                Workflow result = apiInstance.TeamMembersIdTeamWorkflowsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamWorkflowsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidteamworkflowsget"></a>
# **TeamMembersIdTeamWorkflowsGet**
> List<Workflow> TeamMembersIdTeamWorkflowsGet (string id, string filter = null)

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
    public class TeamMembersIdTeamWorkflowsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries workflows of Team.
                List&lt;Workflow&gt; result = apiInstance.TeamMembersIdTeamWorkflowsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamWorkflowsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Workflow>**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidteamworkflowspost"></a>
# **TeamMembersIdTeamWorkflowsPost**
> Workflow TeamMembersIdTeamWorkflowsPost (string id, Workflow data = null)

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
    public class TeamMembersIdTeamWorkflowsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Workflow(); // Workflow |  (optional) 

            try
            {
                // Creates a new instance in workflows of this model.
                Workflow result = apiInstance.TeamMembersIdTeamWorkflowsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTeamWorkflowsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Workflow**](Workflow.md)|  | [optional] 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatescountget"></a>
# **TeamMembersIdTemplatesCountGet**
> InlineResponse2001 TeamMembersIdTemplatesCountGet (string id, string where = null)

Counts templates of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdTemplatesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatesdelete"></a>
# **TeamMembersIdTemplatesDelete**
> void TeamMembersIdTemplatesDelete (string id)

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
    public class TeamMembersIdTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all templates of this model.
                apiInstance.TeamMembersIdTemplatesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatesfkdelete"></a>
# **TeamMembersIdTemplatesFkDelete**
> void TeamMembersIdTemplatesFkDelete (string id, string fk)

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
    public class TeamMembersIdTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.TeamMembersIdTemplatesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatesfkflashvarsget"></a>
# **TeamMembersIdTemplatesFkFlashvarsGet**
> FlashVar TeamMembersIdTemplatesFkFlashvarsGet (string id, string id2, string fk)

Find Template FlashVars by id

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTemplatesFkFlashvarsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var fk = fk_example;  // string | 

            try
            {
                // Find Template FlashVars by id
                FlashVar result = apiInstance.TeamMembersIdTemplatesFkFlashvarsGet(id, id2, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesFkFlashvarsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **fk** | **string**|  | 

### Return type

[**FlashVar**](FlashVar.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatesfkget"></a>
# **TeamMembersIdTemplatesFkGet**
> Template TeamMembersIdTemplatesFkGet (string id, string fk)

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
    public class TeamMembersIdTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.TeamMembersIdTemplatesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatesfkput"></a>
# **TeamMembersIdTemplatesFkPut**
> Template TeamMembersIdTemplatesFkPut (string id, string fk, Template data = null)

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
    public class TeamMembersIdTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.TeamMembersIdTemplatesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidtemplatesget"></a>
# **TeamMembersIdTemplatesGet**
> List<Template> TeamMembersIdTemplatesGet (string id, string filter = null)

Queries templates of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of TeamMember.
                List&lt;Template&gt; result = apiInstance.TeamMembersIdTemplatesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatespost"></a>
# **TeamMembersIdTemplatesPost**
> Template TeamMembersIdTemplatesPost (string id, Template data = null)

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
    public class TeamMembersIdTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.TeamMembersIdTemplatesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatesrelfkdelete"></a>
# **TeamMembersIdTemplatesRelFkDelete**
> void TeamMembersIdTemplatesRelFkDelete (string id, string fk)

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
    public class TeamMembersIdTemplatesRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Remove the templates relation to an item by id.
                apiInstance.TeamMembersIdTemplatesRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatesrelfkhead"></a>
# **TeamMembersIdTemplatesRelFkHead**
> bool? TeamMembersIdTemplatesRelFkHead (string id, string fk)

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
    public class TeamMembersIdTemplatesRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Check the existence of templates relation to an item by id.
                bool? result = apiInstance.TeamMembersIdTemplatesRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtemplatesrelfkput"></a>
# **TeamMembersIdTemplatesRelFkPut**
> TemplateMember TeamMembersIdTemplatesRelFkPut (string id, string fk, TemplateMember data = null)

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
    public class TeamMembersIdTemplatesRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new TemplateMember(); // TemplateMember |  (optional) 

            try
            {
                // Add a related item by id for templates.
                TemplateMember result = apiInstance.TeamMembersIdTemplatesRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTemplatesRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for templates | 
 **data** | [**TemplateMember**](TemplateMember.md)|  | [optional] 

### Return type

[**TemplateMember**](TemplateMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtweaktemplatefoldersget"></a>
# **TeamMembersIdTweakTemplateFoldersGet**
> List<TeamTemplateFolder> TeamMembersIdTweakTemplateFoldersGet (string id, string id2, string filter = null)

List Tweak Templates Folders

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTweakTemplateFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // List Tweak Templates Folders
                List&lt;TeamTemplateFolder&gt; result = apiInstance.TeamMembersIdTweakTemplateFoldersGet(id, id2, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTweakTemplateFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<TeamTemplateFolder>**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtweaktemplatefoldersnkget"></a>
# **TeamMembersIdTweakTemplateFoldersNkGet**
> TeamTemplateFolder TeamMembersIdTweakTemplateFoldersNkGet (string id, string id2, string nk, string filter = null)

Get Tweak Templates Folders details

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTweakTemplateFoldersNkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var nk = nk_example;  // string | TemplateFolder id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Get Tweak Templates Folders details
                TeamTemplateFolder result = apiInstance.TeamMembersIdTweakTemplateFoldersNkGet(id, id2, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTweakTemplateFoldersNkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **nk** | **string**| TemplateFolder id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtweaktemplatefoldersnktemplatesfkget"></a>
# **TeamMembersIdTweakTemplateFoldersNkTemplatesFkGet**
> Template TeamMembersIdTweakTemplateFoldersNkTemplatesFkGet (string id, string id2, string nk, string fk, string filter = null)

Get Tweak Template details within a Tweak Template Folder

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTweakTemplateFoldersNkTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var nk = nk_example;  // string | TemplateFolder id
            var fk = fk_example;  // string | Template id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Get Tweak Template details within a Tweak Template Folder
                Template result = apiInstance.TeamMembersIdTweakTemplateFoldersNkTemplatesFkGet(id, id2, nk, fk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTweakTemplateFoldersNkTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **nk** | **string**| TemplateFolder id | 
 **fk** | **string**| Template id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtweaktemplatefoldersnktemplatesget"></a>
# **TeamMembersIdTweakTemplateFoldersNkTemplatesGet**
> List<Template> TeamMembersIdTweakTemplateFoldersNkTemplatesGet (string id, string id2, string nk, string filter = null)

List Tweak Templates within a Tweak Template Folder

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTweakTemplateFoldersNkTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var nk = nk_example;  // string | TemplateFolder id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // List Tweak Templates within a Tweak Template Folder
                List&lt;Template&gt; result = apiInstance.TeamMembersIdTweakTemplateFoldersNkTemplatesGet(id, id2, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTweakTemplateFoldersNkTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **nk** | **string**| TemplateFolder id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtweaktemplatesfkflashvarsget"></a>
# **TeamMembersIdTweakTemplatesFkFlashvarsGet**
> FlashVar TeamMembersIdTweakTemplatesFkFlashvarsGet (string id, string id2, string fk)

Find Template FlashVars by id

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTweakTemplatesFkFlashvarsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | 
            var fk = fk_example;  // string | 

            try
            {
                // Find Template FlashVars by id
                FlashVar result = apiInstance.TeamMembersIdTweakTemplatesFkFlashvarsGet(id, id2, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTweakTemplatesFkFlashvarsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**|  | 
 **fk** | **string**|  | 

### Return type

[**FlashVar**](FlashVar.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtweaktemplatesfkget"></a>
# **TeamMembersIdTweakTemplatesFkGet**
> Template TeamMembersIdTweakTemplatesFkGet (string id, string id2, string fk, string filter = null)

Get Tweak Template details

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTweakTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Template id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Get Tweak Template details
                Template result = apiInstance.TeamMembersIdTweakTemplatesFkGet(id, id2, fk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTweakTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **fk** | **string**| Template id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidtweaktemplatesget"></a>
# **TeamMembersIdTweakTemplatesGet**
> List<Template> TeamMembersIdTweakTemplatesGet (string id, string id2, string filter = null)

List Tweak Templates

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdTweakTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var id2 = id_example;  // string | TeamMember id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // List Tweak Templates
                List&lt;Template&gt; result = apiInstance.TeamMembersIdTweakTemplatesGet(id, id2, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdTweakTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **id2** | **string**| TeamMember id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiduploadedtemplatescountget"></a>
# **TeamMembersIdUploadedTemplatesCountGet**
> InlineResponse2001 TeamMembersIdUploadedTemplatesCountGet (string id, string where = null)

Counts uploadedTemplates of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdUploadedTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts uploadedTemplates of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdUploadedTemplatesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdUploadedTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiduploadedtemplatesdelete"></a>
# **TeamMembersIdUploadedTemplatesDelete**
> void TeamMembersIdUploadedTemplatesDelete (string id)

Deletes all uploadedTemplates of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdUploadedTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all uploadedTemplates of this model.
                apiInstance.TeamMembersIdUploadedTemplatesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdUploadedTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiduploadedtemplatesfkdelete"></a>
# **TeamMembersIdUploadedTemplatesFkDelete**
> void TeamMembersIdUploadedTemplatesFkDelete (string id, string fk)

Delete a related item by id for uploadedTemplates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdUploadedTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for uploadedTemplates

            try
            {
                // Delete a related item by id for uploadedTemplates.
                apiInstance.TeamMembersIdUploadedTemplatesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdUploadedTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for uploadedTemplates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiduploadedtemplatesfkget"></a>
# **TeamMembersIdUploadedTemplatesFkGet**
> Template TeamMembersIdUploadedTemplatesFkGet (string id, string fk)

Find a related item by id for uploadedTemplates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdUploadedTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for uploadedTemplates

            try
            {
                // Find a related item by id for uploadedTemplates.
                Template result = apiInstance.TeamMembersIdUploadedTemplatesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdUploadedTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for uploadedTemplates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiduploadedtemplatesfkput"></a>
# **TeamMembersIdUploadedTemplatesFkPut**
> Template TeamMembersIdUploadedTemplatesFkPut (string id, string fk, Template data = null)

Update a related item by id for uploadedTemplates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdUploadedTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for uploadedTemplates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for uploadedTemplates.
                Template result = apiInstance.TeamMembersIdUploadedTemplatesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdUploadedTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for uploadedTemplates | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiduploadedtemplatesget"></a>
# **TeamMembersIdUploadedTemplatesGet**
> List<Template> TeamMembersIdUploadedTemplatesGet (string id, string filter = null)

Queries uploadedTemplates of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdUploadedTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries uploadedTemplates of TeamMember.
                List&lt;Template&gt; result = apiInstance.TeamMembersIdUploadedTemplatesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdUploadedTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersiduploadedtemplatespost"></a>
# **TeamMembersIdUploadedTemplatesPost**
> Template TeamMembersIdUploadedTemplatesPost (string id, Template data = null)

Creates a new instance in uploadedTemplates of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdUploadedTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in uploadedTemplates of this model.
                Template result = apiInstance.TeamMembersIdUploadedTemplatesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdUploadedTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidworkflowscountget"></a>
# **TeamMembersIdWorkflowsCountGet**
> InlineResponse2001 TeamMembersIdWorkflowsCountGet (string id, string where = null)

Counts workflows of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdWorkflowsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts workflows of TeamMember.
                InlineResponse2001 result = apiInstance.TeamMembersIdWorkflowsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdWorkflowsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidworkflowsdelete"></a>
# **TeamMembersIdWorkflowsDelete**
> void TeamMembersIdWorkflowsDelete (string id)

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
    public class TeamMembersIdWorkflowsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id

            try
            {
                // Deletes all workflows of this model.
                apiInstance.TeamMembersIdWorkflowsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdWorkflowsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidworkflowsfkdelete"></a>
# **TeamMembersIdWorkflowsFkDelete**
> void TeamMembersIdWorkflowsFkDelete (string id, string fk)

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
    public class TeamMembersIdWorkflowsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for workflows

            try
            {
                // Delete a related item by id for workflows.
                apiInstance.TeamMembersIdWorkflowsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdWorkflowsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for workflows | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidworkflowsfkget"></a>
# **TeamMembersIdWorkflowsFkGet**
> Workflow TeamMembersIdWorkflowsFkGet (string id, string fk)

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
    public class TeamMembersIdWorkflowsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for workflows

            try
            {
                // Find a related item by id for workflows.
                Workflow result = apiInstance.TeamMembersIdWorkflowsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdWorkflowsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **fk** | **string**| Foreign key for workflows | 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidworkflowsfkput"></a>
# **TeamMembersIdWorkflowsFkPut**
> Workflow TeamMembersIdWorkflowsFkPut (string id, string fk, Workflow data = null)

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
    public class TeamMembersIdWorkflowsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var fk = fk_example;  // string | Foreign key for workflows
            var data = new Workflow(); // Workflow |  (optional) 

            try
            {
                // Update a related item by id for workflows.
                Workflow result = apiInstance.TeamMembersIdWorkflowsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdWorkflowsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
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

<a name="teammembersidworkflowsget"></a>
# **TeamMembersIdWorkflowsGet**
> List<Workflow> TeamMembersIdWorkflowsGet (string id, string filter = null)

Queries workflows of TeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamMembersIdWorkflowsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries workflows of TeamMember.
                List&lt;Workflow&gt; result = apiInstance.TeamMembersIdWorkflowsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdWorkflowsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Workflow>**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersidworkflowspost"></a>
# **TeamMembersIdWorkflowsPost**
> Workflow TeamMembersIdWorkflowsPost (string id, Workflow data = null)

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
    public class TeamMembersIdWorkflowsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var data = new Workflow(); // Workflow |  (optional) 

            try
            {
                // Creates a new instance in workflows of this model.
                Workflow result = apiInstance.TeamMembersIdWorkflowsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersIdWorkflowsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **data** | [**Workflow**](Workflow.md)|  | [optional] 

### Return type

[**Workflow**](Workflow.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammemberspatch"></a>
# **TeamMembersPatch**
> TeamMember TeamMembersPatch (TeamMember data = null)

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
    public class TeamMembersPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var data = new TeamMember(); // TeamMember | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TeamMember result = apiInstance.TeamMembersPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamMember**](TeamMember.md)| Model instance data | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammemberspost"></a>
# **TeamMembersPost**
> TeamMember TeamMembersPost (TeamMember data = null)

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
    public class TeamMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var data = new TeamMember(); // TeamMember | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TeamMember result = apiInstance.TeamMembersPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamMember**](TeamMember.md)| Model instance data | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersput"></a>
# **TeamMembersPut**
> TeamMember TeamMembersPut (TeamMember data = null)

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
    public class TeamMembersPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var data = new TeamMember(); // TeamMember | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamMember result = apiInstance.TeamMembersPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamMember**](TeamMember.md)| Model instance data | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersreplaceorcreatepost"></a>
# **TeamMembersReplaceOrCreatePost**
> TeamMember TeamMembersReplaceOrCreatePost (TeamMember data = null)

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
    public class TeamMembersReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var data = new TeamMember(); // TeamMember | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamMember result = apiInstance.TeamMembersReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamMember**](TeamMember.md)| Model instance data | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersupdatepost"></a>
# **TeamMembersUpdatePost**
> InlineResponse2003 TeamMembersUpdatePost (string where = null, TeamMember data = null)

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
    public class TeamMembersUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamMember(); // TeamMember | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2003 result = apiInstance.TeamMembersUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamMember**](TeamMember.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersupsertwithwherepost"></a>
# **TeamMembersUpsertWithWherePost**
> TeamMember TeamMembersUpsertWithWherePost (string where = null, TeamMember data = null)

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
    public class TeamMembersUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamMemberApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamMember(); // TeamMember | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TeamMember result = apiInstance.TeamMembersUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMemberApi.TeamMembersUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamMember**](TeamMember.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

