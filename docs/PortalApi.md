# TweakApi.Api.PortalApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PortalsChangeStreamGet**](PortalApi.md#portalschangestreamget) | **GET** /Portals/change-stream | Create a change stream.
[**PortalsChangeStreamPost**](PortalApi.md#portalschangestreampost) | **POST** /Portals/change-stream | Create a change stream.
[**PortalsCountGet**](PortalApi.md#portalscountget) | **GET** /Portals/count | Count instances of the model matched by where from the data source.
[**PortalsFindOneGet**](PortalApi.md#portalsfindoneget) | **GET** /Portals/findOne | Find first instance of the model matched by filter from the data source.
[**PortalsGet**](PortalApi.md#portalsget) | **GET** /Portals | Find all instances of the model matched by filter from the data source.
[**PortalsIdDelete**](PortalApi.md#portalsiddelete) | **DELETE** /Portals/{id} | Delete a model instance by {{id}} from the data source.
[**PortalsIdDesignFoldersCountGet**](PortalApi.md#portalsiddesignfolderscountget) | **GET** /Portals/{id}/designFolders/count | Counts designFolders of Portal.
[**PortalsIdDesignFoldersDelete**](PortalApi.md#portalsiddesignfoldersdelete) | **DELETE** /Portals/{id}/designFolders | Deletes all designFolders of this model.
[**PortalsIdDesignFoldersFkDelete**](PortalApi.md#portalsiddesignfoldersfkdelete) | **DELETE** /Portals/{id}/designFolders/{fk} | Delete a related item by id for designFolders.
[**PortalsIdDesignFoldersFkGet**](PortalApi.md#portalsiddesignfoldersfkget) | **GET** /Portals/{id}/designFolders/{fk} | Find a related item by id for designFolders.
[**PortalsIdDesignFoldersFkPut**](PortalApi.md#portalsiddesignfoldersfkput) | **PUT** /Portals/{id}/designFolders/{fk} | Update a related item by id for designFolders.
[**PortalsIdDesignFoldersGet**](PortalApi.md#portalsiddesignfoldersget) | **GET** /Portals/{id}/designFolders | Queries designFolders of Portal.
[**PortalsIdDesignFoldersPost**](PortalApi.md#portalsiddesignfolderspost) | **POST** /Portals/{id}/designFolders | Creates a new instance in designFolders of this model.
[**PortalsIdDesignsCountGet**](PortalApi.md#portalsiddesignscountget) | **GET** /Portals/{id}/designs/count | Counts designs of Portal.
[**PortalsIdDesignsDelete**](PortalApi.md#portalsiddesignsdelete) | **DELETE** /Portals/{id}/designs | Deletes all designs of this model.
[**PortalsIdDesignsFkDelete**](PortalApi.md#portalsiddesignsfkdelete) | **DELETE** /Portals/{id}/designs/{fk} | Delete a related item by id for designs.
[**PortalsIdDesignsFkGet**](PortalApi.md#portalsiddesignsfkget) | **GET** /Portals/{id}/designs/{fk} | Find a related item by id for designs.
[**PortalsIdDesignsFkPut**](PortalApi.md#portalsiddesignsfkput) | **PUT** /Portals/{id}/designs/{fk} | Update a related item by id for designs.
[**PortalsIdDesignsGet**](PortalApi.md#portalsiddesignsget) | **GET** /Portals/{id}/designs | Queries designs of Portal.
[**PortalsIdDesignsNkAssigneeGet**](PortalApi.md#portalsiddesignsnkassigneeget) | **GET** /Portals/{id}/designs/{nk}/assignee | Fetches belongsTo relation assignee.
[**PortalsIdDesignsNkCommentersCountGet**](PortalApi.md#portalsiddesignsnkcommenterscountget) | **GET** /Portals/{id}/designs/{nk}/commenters/count | Counts commenters of Design.
[**PortalsIdDesignsNkCommentersDelete**](PortalApi.md#portalsiddesignsnkcommentersdelete) | **DELETE** /Portals/{id}/designs/{nk}/commenters | Deletes all commenters of this model.
[**PortalsIdDesignsNkCommentersFkDelete**](PortalApi.md#portalsiddesignsnkcommentersfkdelete) | **DELETE** /Portals/{id}/designs/{nk}/commenters/{fk} | Delete a related item by id for commenters.
[**PortalsIdDesignsNkCommentersFkGet**](PortalApi.md#portalsiddesignsnkcommentersfkget) | **GET** /Portals/{id}/designs/{nk}/commenters/{fk} | Find a related item by id for commenters.
[**PortalsIdDesignsNkCommentersFkPut**](PortalApi.md#portalsiddesignsnkcommentersfkput) | **PUT** /Portals/{id}/designs/{nk}/commenters/{fk} | Update a related item by id for commenters.
[**PortalsIdDesignsNkCommentersGet**](PortalApi.md#portalsiddesignsnkcommentersget) | **GET** /Portals/{id}/designs/{nk}/commenters | Queries commenters of Design.
[**PortalsIdDesignsNkCommentersPost**](PortalApi.md#portalsiddesignsnkcommenterspost) | **POST** /Portals/{id}/designs/{nk}/commenters | Creates a new instance in commenters of this model.
[**PortalsIdDesignsNkCommentersRelFkDelete**](PortalApi.md#portalsiddesignsnkcommentersrelfkdelete) | **DELETE** /Portals/{id}/designs/{nk}/commenters/rel/{fk} | Remove the commenters relation to an item by id.
[**PortalsIdDesignsNkCommentersRelFkHead**](PortalApi.md#portalsiddesignsnkcommentersrelfkhead) | **HEAD** /Portals/{id}/designs/{nk}/commenters/rel/{fk} | Check the existence of commenters relation to an item by id.
[**PortalsIdDesignsNkCommentersRelFkPut**](PortalApi.md#portalsiddesignsnkcommentersrelfkput) | **PUT** /Portals/{id}/designs/{nk}/commenters/rel/{fk} | Add a related item by id for commenters.
[**PortalsIdDesignsNkCommentsCountGet**](PortalApi.md#portalsiddesignsnkcommentscountget) | **GET** /Portals/{id}/designs/{nk}/comments/count | Counts comments of Design.
[**PortalsIdDesignsNkCommentsDelete**](PortalApi.md#portalsiddesignsnkcommentsdelete) | **DELETE** /Portals/{id}/designs/{nk}/comments | Deletes all comments of this model.
[**PortalsIdDesignsNkCommentsFkDelete**](PortalApi.md#portalsiddesignsnkcommentsfkdelete) | **DELETE** /Portals/{id}/designs/{nk}/comments/{fk} | Delete a related item by id for comments.
[**PortalsIdDesignsNkCommentsFkGet**](PortalApi.md#portalsiddesignsnkcommentsfkget) | **GET** /Portals/{id}/designs/{nk}/comments/{fk} | Find a related item by id for comments.
[**PortalsIdDesignsNkCommentsFkPut**](PortalApi.md#portalsiddesignsnkcommentsfkput) | **PUT** /Portals/{id}/designs/{nk}/comments/{fk} | Update a related item by id for comments.
[**PortalsIdDesignsNkCommentsGet**](PortalApi.md#portalsiddesignsnkcommentsget) | **GET** /Portals/{id}/designs/{nk}/comments | Queries comments of Design.
[**PortalsIdDesignsNkCommentsPost**](PortalApi.md#portalsiddesignsnkcommentspost) | **POST** /Portals/{id}/designs/{nk}/comments | Creates a new instance in comments of this model.
[**PortalsIdDesignsNkCustomerGet**](PortalApi.md#portalsiddesignsnkcustomerget) | **GET** /Portals/{id}/designs/{nk}/customer | Fetches belongsTo relation customer.
[**PortalsIdDesignsNkExportsCountGet**](PortalApi.md#portalsiddesignsnkexportscountget) | **GET** /Portals/{id}/designs/{nk}/exports/count | Counts exports of Design.
[**PortalsIdDesignsNkExportsDelete**](PortalApi.md#portalsiddesignsnkexportsdelete) | **DELETE** /Portals/{id}/designs/{nk}/exports | Deletes all exports of this model.
[**PortalsIdDesignsNkExportsFkDelete**](PortalApi.md#portalsiddesignsnkexportsfkdelete) | **DELETE** /Portals/{id}/designs/{nk}/exports/{fk} | Delete a related item by id for exports.
[**PortalsIdDesignsNkExportsFkGet**](PortalApi.md#portalsiddesignsnkexportsfkget) | **GET** /Portals/{id}/designs/{nk}/exports/{fk} | Find a related item by id for exports.
[**PortalsIdDesignsNkExportsFkPut**](PortalApi.md#portalsiddesignsnkexportsfkput) | **PUT** /Portals/{id}/designs/{nk}/exports/{fk} | Update a related item by id for exports.
[**PortalsIdDesignsNkExportsGet**](PortalApi.md#portalsiddesignsnkexportsget) | **GET** /Portals/{id}/designs/{nk}/exports | Queries exports of Design.
[**PortalsIdDesignsNkExportsPost**](PortalApi.md#portalsiddesignsnkexportspost) | **POST** /Portals/{id}/designs/{nk}/exports | Creates a new instance in exports of this model.
[**PortalsIdDesignsNkFolderGet**](PortalApi.md#portalsiddesignsnkfolderget) | **GET** /Portals/{id}/designs/{nk}/folder | Fetches belongsTo relation folder.
[**PortalsIdDesignsNkPortalGet**](PortalApi.md#portalsiddesignsnkportalget) | **GET** /Portals/{id}/designs/{nk}/portal | Fetches belongsTo relation portal.
[**PortalsIdDesignsNkRequesterGet**](PortalApi.md#portalsiddesignsnkrequesterget) | **GET** /Portals/{id}/designs/{nk}/requester | Fetches belongsTo relation requester.
[**PortalsIdDesignsNkReviewerGet**](PortalApi.md#portalsiddesignsnkreviewerget) | **GET** /Portals/{id}/designs/{nk}/reviewer | Fetches belongsTo relation reviewer.
[**PortalsIdDesignsNkTagsCountGet**](PortalApi.md#portalsiddesignsnktagscountget) | **GET** /Portals/{id}/designs/{nk}/tags/count | Counts tags of Design.
[**PortalsIdDesignsNkTagsDelete**](PortalApi.md#portalsiddesignsnktagsdelete) | **DELETE** /Portals/{id}/designs/{nk}/tags | Deletes all tags of this model.
[**PortalsIdDesignsNkTagsFkDelete**](PortalApi.md#portalsiddesignsnktagsfkdelete) | **DELETE** /Portals/{id}/designs/{nk}/tags/{fk} | Delete a related item by id for tags.
[**PortalsIdDesignsNkTagsFkGet**](PortalApi.md#portalsiddesignsnktagsfkget) | **GET** /Portals/{id}/designs/{nk}/tags/{fk} | Find a related item by id for tags.
[**PortalsIdDesignsNkTagsFkPut**](PortalApi.md#portalsiddesignsnktagsfkput) | **PUT** /Portals/{id}/designs/{nk}/tags/{fk} | Update a related item by id for tags.
[**PortalsIdDesignsNkTagsGet**](PortalApi.md#portalsiddesignsnktagsget) | **GET** /Portals/{id}/designs/{nk}/tags | Queries tags of Design.
[**PortalsIdDesignsNkTagsPost**](PortalApi.md#portalsiddesignsnktagspost) | **POST** /Portals/{id}/designs/{nk}/tags | Creates a new instance in tags of this model.
[**PortalsIdDesignsNkTagsRelFkDelete**](PortalApi.md#portalsiddesignsnktagsrelfkdelete) | **DELETE** /Portals/{id}/designs/{nk}/tags/rel/{fk} | Remove the tags relation to an item by id.
[**PortalsIdDesignsNkTagsRelFkHead**](PortalApi.md#portalsiddesignsnktagsrelfkhead) | **HEAD** /Portals/{id}/designs/{nk}/tags/rel/{fk} | Check the existence of tags relation to an item by id.
[**PortalsIdDesignsNkTagsRelFkPut**](PortalApi.md#portalsiddesignsnktagsrelfkput) | **PUT** /Portals/{id}/designs/{nk}/tags/rel/{fk} | Add a related item by id for tags.
[**PortalsIdDesignsNkTemplateGet**](PortalApi.md#portalsiddesignsnktemplateget) | **GET** /Portals/{id}/designs/{nk}/template | Fetches belongsTo relation template.
[**PortalsIdDesignsPost**](PortalApi.md#portalsiddesignspost) | **POST** /Portals/{id}/designs | Creates a new instance in designs of this model.
[**PortalsIdExistsGet**](PortalApi.md#portalsidexistsget) | **GET** /Portals/{id}/exists | Check whether a model instance exists in the data source.
[**PortalsIdGet**](PortalApi.md#portalsidget) | **GET** /Portals/{id} | Find a model instance by {{id}} from the data source.
[**PortalsIdHead**](PortalApi.md#portalsidhead) | **HEAD** /Portals/{id} | Check whether a model instance exists in the data source.
[**PortalsIdImageFoldersCountGet**](PortalApi.md#portalsidimagefolderscountget) | **GET** /Portals/{id}/imageFolders/count | Counts imageFolders of Portal.
[**PortalsIdImageFoldersDelete**](PortalApi.md#portalsidimagefoldersdelete) | **DELETE** /Portals/{id}/imageFolders | Deletes all imageFolders of this model.
[**PortalsIdImageFoldersFkDelete**](PortalApi.md#portalsidimagefoldersfkdelete) | **DELETE** /Portals/{id}/imageFolders/{fk} | Delete a related item by id for imageFolders.
[**PortalsIdImageFoldersFkGet**](PortalApi.md#portalsidimagefoldersfkget) | **GET** /Portals/{id}/imageFolders/{fk} | Find a related item by id for imageFolders.
[**PortalsIdImageFoldersFkPut**](PortalApi.md#portalsidimagefoldersfkput) | **PUT** /Portals/{id}/imageFolders/{fk} | Update a related item by id for imageFolders.
[**PortalsIdImageFoldersGet**](PortalApi.md#portalsidimagefoldersget) | **GET** /Portals/{id}/imageFolders | Queries imageFolders of Portal.
[**PortalsIdImageFoldersPost**](PortalApi.md#portalsidimagefolderspost) | **POST** /Portals/{id}/imageFolders | Creates a new instance in imageFolders of this model.
[**PortalsIdImageFoldersRelFkDelete**](PortalApi.md#portalsidimagefoldersrelfkdelete) | **DELETE** /Portals/{id}/imageFolders/rel/{fk} | Remove the imageFolders relation to an item by id.
[**PortalsIdImageFoldersRelFkHead**](PortalApi.md#portalsidimagefoldersrelfkhead) | **HEAD** /Portals/{id}/imageFolders/rel/{fk} | Check the existence of imageFolders relation to an item by id.
[**PortalsIdImageFoldersRelFkPut**](PortalApi.md#portalsidimagefoldersrelfkput) | **PUT** /Portals/{id}/imageFolders/rel/{fk} | Add a related item by id for imageFolders.
[**PortalsIdInvitationTicketsFkDelete**](PortalApi.md#portalsidinvitationticketsfkdelete) | **DELETE** /Portals/{id}/invitationTickets/{fk} | Delete InvitationTickets for this Portal
[**PortalsIdInvitationTicketsFkGet**](PortalApi.md#portalsidinvitationticketsfkget) | **GET** /Portals/{id}/invitationTickets/{fk} | Get InvitationTicket by Id for this Portal
[**PortalsIdInvitationTicketsGet**](PortalApi.md#portalsidinvitationticketsget) | **GET** /Portals/{id}/invitationTickets | List InvitationTickets for this Portal
[**PortalsIdLogoPut**](PortalApi.md#portalsidlogoput) | **PUT** /Portals/{id}/logo | Change logo
[**PortalsIdMembersCountGet**](PortalApi.md#portalsidmemberscountget) | **GET** /Portals/{id}/members/count | Counts members of Portal.
[**PortalsIdMembersDelete**](PortalApi.md#portalsidmembersdelete) | **DELETE** /Portals/{id}/members | Deletes all members of this model.
[**PortalsIdMembersFkDelete**](PortalApi.md#portalsidmembersfkdelete) | **DELETE** /Portals/{id}/members/{fk} | Delete a related item by id for members.
[**PortalsIdMembersFkGet**](PortalApi.md#portalsidmembersfkget) | **GET** /Portals/{id}/members/{fk} | Find a related item by id for members.
[**PortalsIdMembersFkPut**](PortalApi.md#portalsidmembersfkput) | **PUT** /Portals/{id}/members/{fk} | Update a related item by id for members.
[**PortalsIdMembersGet**](PortalApi.md#portalsidmembersget) | **GET** /Portals/{id}/members | Queries members of Portal.
[**PortalsIdMembersPost**](PortalApi.md#portalsidmemberspost) | **POST** /Portals/{id}/members | Creates a new instance in members of this model.
[**PortalsIdMembersRelFkDelete**](PortalApi.md#portalsidmembersrelfkdelete) | **DELETE** /Portals/{id}/members/rel/{fk} | Remove the members relation to an item by id.
[**PortalsIdMembersRelFkHead**](PortalApi.md#portalsidmembersrelfkhead) | **HEAD** /Portals/{id}/members/rel/{fk} | Check the existence of members relation to an item by id.
[**PortalsIdMembersRelFkPut**](PortalApi.md#portalsidmembersrelfkput) | **PUT** /Portals/{id}/members/rel/{fk} | Add a related item by id for members.
[**PortalsIdPatch**](PortalApi.md#portalsidpatch) | **PATCH** /Portals/{id} | Patch attributes for a model instance and persist it into the data source.
[**PortalsIdPortalMembersCountGet**](PortalApi.md#portalsidportalmemberscountget) | **GET** /Portals/{id}/portalMembers/count | Counts portalMembers of Portal.
[**PortalsIdPortalMembersDelete**](PortalApi.md#portalsidportalmembersdelete) | **DELETE** /Portals/{id}/portalMembers | Deletes all portalMembers of this model.
[**PortalsIdPortalMembersFkDelete**](PortalApi.md#portalsidportalmembersfkdelete) | **DELETE** /Portals/{id}/portalMembers/{fk} | Delete a related item by id for portalMembers.
[**PortalsIdPortalMembersFkGet**](PortalApi.md#portalsidportalmembersfkget) | **GET** /Portals/{id}/portalMembers/{fk} | Find a related item by id for portalMembers.
[**PortalsIdPortalMembersFkPut**](PortalApi.md#portalsidportalmembersfkput) | **PUT** /Portals/{id}/portalMembers/{fk} | Update a related item by id for portalMembers.
[**PortalsIdPortalMembersGet**](PortalApi.md#portalsidportalmembersget) | **GET** /Portals/{id}/portalMembers | Queries portalMembers of Portal.
[**PortalsIdPortalMembersPost**](PortalApi.md#portalsidportalmemberspost) | **POST** /Portals/{id}/portalMembers | Creates a new instance in portalMembers of this model.
[**PortalsIdPut**](PortalApi.md#portalsidput) | **PUT** /Portals/{id} | Replace attributes for a model instance and persist it into the data source.
[**PortalsIdReplacePost**](PortalApi.md#portalsidreplacepost) | **POST** /Portals/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**PortalsIdTeamGet**](PortalApi.md#portalsidteamget) | **GET** /Portals/{id}/team | Fetches belongsTo relation team.
[**PortalsIdTemplateFoldersCountGet**](PortalApi.md#portalsidtemplatefolderscountget) | **GET** /Portals/{id}/templateFolders/count | Counts templateFolders of Portal.
[**PortalsIdTemplateFoldersDelete**](PortalApi.md#portalsidtemplatefoldersdelete) | **DELETE** /Portals/{id}/templateFolders | Deletes all templateFolders of this model.
[**PortalsIdTemplateFoldersFkDelete**](PortalApi.md#portalsidtemplatefoldersfkdelete) | **DELETE** /Portals/{id}/templateFolders/{fk} | Delete a related item by id for templateFolders.
[**PortalsIdTemplateFoldersFkGet**](PortalApi.md#portalsidtemplatefoldersfkget) | **GET** /Portals/{id}/templateFolders/{fk} | Find a related item by id for templateFolders.
[**PortalsIdTemplateFoldersFkPut**](PortalApi.md#portalsidtemplatefoldersfkput) | **PUT** /Portals/{id}/templateFolders/{fk} | Update a related item by id for templateFolders.
[**PortalsIdTemplateFoldersGet**](PortalApi.md#portalsidtemplatefoldersget) | **GET** /Portals/{id}/templateFolders | Queries templateFolders of Portal.
[**PortalsIdTemplateFoldersNkTemplatesFkRelDelete**](PortalApi.md#portalsidtemplatefoldersnktemplatesfkreldelete) | **DELETE** /Portals/{id}/templateFolders/{nk}/templates/{fk}/rel | Unlink folder with Template and Portal
[**PortalsIdTemplateFoldersNkTemplatesFkRelPut**](PortalApi.md#portalsidtemplatefoldersnktemplatesfkrelput) | **PUT** /Portals/{id}/templateFolders/{nk}/templates/{fk}/rel | Link folder with Template and Portal
[**PortalsIdTemplateFoldersPost**](PortalApi.md#portalsidtemplatefolderspost) | **POST** /Portals/{id}/templateFolders | Creates a new instance in templateFolders of this model.
[**PortalsIdTemplateFoldersRootTemplatesGet**](PortalApi.md#portalsidtemplatefoldersroottemplatesget) | **GET** /Portals/{id}/templateFolders/root/templates | List templates on root folder
[**PortalsIdTemplateRelsCountGet**](PortalApi.md#portalsidtemplaterelscountget) | **GET** /Portals/{id}/templateRels/count | Counts templateRels of Portal.
[**PortalsIdTemplateRelsDelete**](PortalApi.md#portalsidtemplaterelsdelete) | **DELETE** /Portals/{id}/templateRels | Deletes all templateRels of this model.
[**PortalsIdTemplateRelsFkDelete**](PortalApi.md#portalsidtemplaterelsfkdelete) | **DELETE** /Portals/{id}/templateRels/{fk} | Delete a related item by id for templateRels.
[**PortalsIdTemplateRelsFkGet**](PortalApi.md#portalsidtemplaterelsfkget) | **GET** /Portals/{id}/templateRels/{fk} | Find a related item by id for templateRels.
[**PortalsIdTemplateRelsFkPut**](PortalApi.md#portalsidtemplaterelsfkput) | **PUT** /Portals/{id}/templateRels/{fk} | Update a related item by id for templateRels.
[**PortalsIdTemplateRelsGet**](PortalApi.md#portalsidtemplaterelsget) | **GET** /Portals/{id}/templateRels | Queries templateRels of Portal.
[**PortalsIdTemplateRelsPost**](PortalApi.md#portalsidtemplaterelspost) | **POST** /Portals/{id}/templateRels | Creates a new instance in templateRels of this model.
[**PortalsIdTemplatesCountGet**](PortalApi.md#portalsidtemplatescountget) | **GET** /Portals/{id}/templates/count | Counts templates of Portal.
[**PortalsIdTemplatesDelete**](PortalApi.md#portalsidtemplatesdelete) | **DELETE** /Portals/{id}/templates | Deletes all templates of this model.
[**PortalsIdTemplatesFkDelete**](PortalApi.md#portalsidtemplatesfkdelete) | **DELETE** /Portals/{id}/templates/{fk} | Delete a related item by id for templates.
[**PortalsIdTemplatesFkDesignsGenerateBulkPost**](PortalApi.md#portalsidtemplatesfkdesignsgeneratebulkpost) | **POST** /Portals/{id}/templates/{fk}/designs/generate/bulk | Generate Design from Template
[**PortalsIdTemplatesFkDesignsGeneratePost**](PortalApi.md#portalsidtemplatesfkdesignsgeneratepost) | **POST** /Portals/{id}/templates/{fk}/designs/generate | Generate Design from Template
[**PortalsIdTemplatesFkGet**](PortalApi.md#portalsidtemplatesfkget) | **GET** /Portals/{id}/templates/{fk} | Find a related item by id for templates.
[**PortalsIdTemplatesFkPut**](PortalApi.md#portalsidtemplatesfkput) | **PUT** /Portals/{id}/templates/{fk} | Update a related item by id for templates.
[**PortalsIdTemplatesGet**](PortalApi.md#portalsidtemplatesget) | **GET** /Portals/{id}/templates | Queries templates of Portal.
[**PortalsIdTemplatesPost**](PortalApi.md#portalsidtemplatespost) | **POST** /Portals/{id}/templates | Creates a new instance in templates of this model.
[**PortalsIdTemplatesRelFkDelete**](PortalApi.md#portalsidtemplatesrelfkdelete) | **DELETE** /Portals/{id}/templates/rel/{fk} | Remove the templates relation to an item by id.
[**PortalsIdTemplatesRelFkHead**](PortalApi.md#portalsidtemplatesrelfkhead) | **HEAD** /Portals/{id}/templates/rel/{fk} | Check the existence of templates relation to an item by id.
[**PortalsIdTemplatesRelFkPut**](PortalApi.md#portalsidtemplatesrelfkput) | **PUT** /Portals/{id}/templates/rel/{fk} | Add a related item by id for templates.
[**PortalsPatch**](PortalApi.md#portalspatch) | **PATCH** /Portals | Patch an existing model instance or insert a new one into the data source.
[**PortalsPost**](PortalApi.md#portalspost) | **POST** /Portals | Create a new instance of the model and persist it into the data source.
[**PortalsPut**](PortalApi.md#portalsput) | **PUT** /Portals | Replace an existing model instance or insert a new one into the data source.
[**PortalsReplaceOrCreatePost**](PortalApi.md#portalsreplaceorcreatepost) | **POST** /Portals/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**PortalsUpdatePost**](PortalApi.md#portalsupdatepost) | **POST** /Portals/update | Update instances of the model matched by {{where}} from the data source.
[**PortalsUpsertWithWherePost**](PortalApi.md#portalsupsertwithwherepost) | **POST** /Portals/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="portalschangestreamget"></a>
# **PortalsChangeStreamGet**
> System.IO.Stream PortalsChangeStreamGet (string options = null)

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
    public class PortalsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.PortalsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsChangeStreamGet: " + e.Message );
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

<a name="portalschangestreampost"></a>
# **PortalsChangeStreamPost**
> System.IO.Stream PortalsChangeStreamPost (string options = null)

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
    public class PortalsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.PortalsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsChangeStreamPost: " + e.Message );
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

<a name="portalscountget"></a>
# **PortalsCountGet**
> InlineResponse200 PortalsCountGet (string where = null)

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
    public class PortalsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.PortalsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsCountGet: " + e.Message );
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

<a name="portalsfindoneget"></a>
# **PortalsFindOneGet**
> Portal PortalsFindOneGet (string filter = null)

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
    public class PortalsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                Portal result = apiInstance.PortalsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsFindOneGet: " + e.Message );
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

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsget"></a>
# **PortalsGet**
> List<Portal> PortalsGet (string filter = null)

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
    public class PortalsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;Portal&gt; result = apiInstance.PortalsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsGet: " + e.Message );
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

[**List<Portal>**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddelete"></a>
# **PortalsIdDelete**
> Object PortalsIdDelete (string id)

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
    public class PortalsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.PortalsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDelete: " + e.Message );
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

<a name="portalsiddesignfolderscountget"></a>
# **PortalsIdDesignFoldersCountGet**
> InlineResponse200 PortalsIdDesignFoldersCountGet (string id, string where = null)

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
    public class PortalsIdDesignFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designFolders of Portal.
                InlineResponse200 result = apiInstance.PortalsIdDesignFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignfoldersdelete"></a>
# **PortalsIdDesignFoldersDelete**
> void PortalsIdDesignFoldersDelete (string id)

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
    public class PortalsIdDesignFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id

            try
            {
                // Deletes all designFolders of this model.
                apiInstance.PortalsIdDesignFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignfoldersfkdelete"></a>
# **PortalsIdDesignFoldersFkDelete**
> void PortalsIdDesignFoldersFkDelete (string id, string fk)

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
    public class PortalsIdDesignFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for designFolders

            try
            {
                // Delete a related item by id for designFolders.
                apiInstance.PortalsIdDesignFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for designFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignfoldersfkget"></a>
# **PortalsIdDesignFoldersFkGet**
> DesignFolder PortalsIdDesignFoldersFkGet (string id, string fk)

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
    public class PortalsIdDesignFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for designFolders

            try
            {
                // Find a related item by id for designFolders.
                DesignFolder result = apiInstance.PortalsIdDesignFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for designFolders | 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignfoldersfkput"></a>
# **PortalsIdDesignFoldersFkPut**
> DesignFolder PortalsIdDesignFoldersFkPut (string id, string fk, DesignFolder data = null)

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
    public class PortalsIdDesignFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for designFolders
            var data = new DesignFolder(); // DesignFolder |  (optional) 

            try
            {
                // Update a related item by id for designFolders.
                DesignFolder result = apiInstance.PortalsIdDesignFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsiddesignfoldersget"></a>
# **PortalsIdDesignFoldersGet**
> List<DesignFolder> PortalsIdDesignFoldersGet (string id, string filter = null)

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
    public class PortalsIdDesignFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designFolders of Portal.
                List&lt;DesignFolder&gt; result = apiInstance.PortalsIdDesignFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignFolder>**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignfolderspost"></a>
# **PortalsIdDesignFoldersPost**
> DesignFolder PortalsIdDesignFoldersPost (string id, DesignFolder data = null)

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
    public class PortalsIdDesignFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new DesignFolder(); // DesignFolder |  (optional) 

            try
            {
                // Creates a new instance in designFolders of this model.
                DesignFolder result = apiInstance.PortalsIdDesignFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**DesignFolder**](DesignFolder.md)|  | [optional] 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignscountget"></a>
# **PortalsIdDesignsCountGet**
> InlineResponse200 PortalsIdDesignsCountGet (string id, string where = null)

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
    public class PortalsIdDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designs of Portal.
                InlineResponse200 result = apiInstance.PortalsIdDesignsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsdelete"></a>
# **PortalsIdDesignsDelete**
> void PortalsIdDesignsDelete (string id)

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
    public class PortalsIdDesignsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id

            try
            {
                // Deletes all designs of this model.
                apiInstance.PortalsIdDesignsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsfkdelete"></a>
# **PortalsIdDesignsFkDelete**
> void PortalsIdDesignsFkDelete (string id, string fk)

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
    public class PortalsIdDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Delete a related item by id for designs.
                apiInstance.PortalsIdDesignsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for designs | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsfkget"></a>
# **PortalsIdDesignsFkGet**
> Design PortalsIdDesignsFkGet (string id, string fk)

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
    public class PortalsIdDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Find a related item by id for designs.
                Design result = apiInstance.PortalsIdDesignsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for designs | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsfkput"></a>
# **PortalsIdDesignsFkPut**
> Design PortalsIdDesignsFkPut (string id, string fk, Design data = null)

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
    public class PortalsIdDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for designs
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for designs.
                Design result = apiInstance.PortalsIdDesignsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsiddesignsget"></a>
# **PortalsIdDesignsGet**
> List<Design> PortalsIdDesignsGet (string id, string filter = null)

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
    public class PortalsIdDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designs of Portal.
                List&lt;Design&gt; result = apiInstance.PortalsIdDesignsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkassigneeget"></a>
# **PortalsIdDesignsNkAssigneeGet**
> TeamMember PortalsIdDesignsNkAssigneeGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation assignee.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkAssigneeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation assignee.
                TeamMember result = apiInstance.PortalsIdDesignsNkAssigneeGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkAssigneeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommenterscountget"></a>
# **PortalsIdDesignsNkCommentersCountGet**
> InlineResponse200 PortalsIdDesignsNkCommentersCountGet (string id, string nk, string where = null)

Counts commenters of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts commenters of Design.
                InlineResponse200 result = apiInstance.PortalsIdDesignsNkCommentersCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentersdelete"></a>
# **PortalsIdDesignsNkCommentersDelete**
> void PortalsIdDesignsNkCommentersDelete (string id, string nk)

Deletes all commenters of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.

            try
            {
                // Deletes all commenters of this model.
                apiInstance.PortalsIdDesignsNkCommentersDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentersfkdelete"></a>
# **PortalsIdDesignsNkCommentersFkDelete**
> void PortalsIdDesignsNkCommentersFkDelete (string id, string nk, string fk)

Delete a related item by id for commenters.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for commenters

            try
            {
                // Delete a related item by id for commenters.
                apiInstance.PortalsIdDesignsNkCommentersFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for commenters | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentersfkget"></a>
# **PortalsIdDesignsNkCommentersFkGet**
> TeamMember PortalsIdDesignsNkCommentersFkGet (string id, string nk, string fk)

Find a related item by id for commenters.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for commenters

            try
            {
                // Find a related item by id for commenters.
                TeamMember result = apiInstance.PortalsIdDesignsNkCommentersFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for commenters | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentersfkput"></a>
# **PortalsIdDesignsNkCommentersFkPut**
> TeamMember PortalsIdDesignsNkCommentersFkPut (string id, string nk, string fk, TeamMember data = null)

Update a related item by id for commenters.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for commenters
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for commenters.
                TeamMember result = apiInstance.PortalsIdDesignsNkCommentersFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for commenters | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentersget"></a>
# **PortalsIdDesignsNkCommentersGet**
> List<TeamMember> PortalsIdDesignsNkCommentersGet (string id, string nk, string filter = null)

Queries commenters of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries commenters of Design.
                List&lt;TeamMember&gt; result = apiInstance.PortalsIdDesignsNkCommentersGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommenterspost"></a>
# **PortalsIdDesignsNkCommentersPost**
> TeamMember PortalsIdDesignsNkCommentersPost (string id, string nk, TeamMember data = null)

Creates a new instance in commenters of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in commenters of this model.
                TeamMember result = apiInstance.PortalsIdDesignsNkCommentersPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentersrelfkdelete"></a>
# **PortalsIdDesignsNkCommentersRelFkDelete**
> void PortalsIdDesignsNkCommentersRelFkDelete (string id, string nk, string fk)

Remove the commenters relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for commenters

            try
            {
                // Remove the commenters relation to an item by id.
                apiInstance.PortalsIdDesignsNkCommentersRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for commenters | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentersrelfkhead"></a>
# **PortalsIdDesignsNkCommentersRelFkHead**
> bool? PortalsIdDesignsNkCommentersRelFkHead (string id, string nk, string fk)

Check the existence of commenters relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for commenters

            try
            {
                // Check the existence of commenters relation to an item by id.
                bool? result = apiInstance.PortalsIdDesignsNkCommentersRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for commenters | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentersrelfkput"></a>
# **PortalsIdDesignsNkCommentersRelFkPut**
> DesignComment PortalsIdDesignsNkCommentersRelFkPut (string id, string nk, string fk, DesignComment data = null)

Add a related item by id for commenters.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for commenters
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Add a related item by id for commenters.
                DesignComment result = apiInstance.PortalsIdDesignsNkCommentersRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for commenters | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentscountget"></a>
# **PortalsIdDesignsNkCommentsCountGet**
> InlineResponse200 PortalsIdDesignsNkCommentsCountGet (string id, string nk, string where = null)

Counts comments of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts comments of Design.
                InlineResponse200 result = apiInstance.PortalsIdDesignsNkCommentsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentsdelete"></a>
# **PortalsIdDesignsNkCommentsDelete**
> void PortalsIdDesignsNkCommentsDelete (string id, string nk)

Deletes all comments of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.

            try
            {
                // Deletes all comments of this model.
                apiInstance.PortalsIdDesignsNkCommentsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentsfkdelete"></a>
# **PortalsIdDesignsNkCommentsFkDelete**
> void PortalsIdDesignsNkCommentsFkDelete (string id, string nk, string fk)

Delete a related item by id for comments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for comments

            try
            {
                // Delete a related item by id for comments.
                apiInstance.PortalsIdDesignsNkCommentsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for comments | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentsfkget"></a>
# **PortalsIdDesignsNkCommentsFkGet**
> DesignComment PortalsIdDesignsNkCommentsFkGet (string id, string nk, string fk)

Find a related item by id for comments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for comments

            try
            {
                // Find a related item by id for comments.
                DesignComment result = apiInstance.PortalsIdDesignsNkCommentsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for comments | 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentsfkput"></a>
# **PortalsIdDesignsNkCommentsFkPut**
> DesignComment PortalsIdDesignsNkCommentsFkPut (string id, string nk, string fk, DesignComment data = null)

Update a related item by id for comments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for comments
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Update a related item by id for comments.
                DesignComment result = apiInstance.PortalsIdDesignsNkCommentsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for comments | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentsget"></a>
# **PortalsIdDesignsNkCommentsGet**
> List<DesignComment> PortalsIdDesignsNkCommentsGet (string id, string nk, string filter = null)

Queries comments of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries comments of Design.
                List&lt;DesignComment&gt; result = apiInstance.PortalsIdDesignsNkCommentsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignComment>**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcommentspost"></a>
# **PortalsIdDesignsNkCommentsPost**
> DesignComment PortalsIdDesignsNkCommentsPost (string id, string nk, DesignComment data = null)

Creates a new instance in comments of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkCommentsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Creates a new instance in comments of this model.
                DesignComment result = apiInstance.PortalsIdDesignsNkCommentsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCommentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkcustomerget"></a>
# **PortalsIdDesignsNkCustomerGet**
> Customer PortalsIdDesignsNkCustomerGet (string id, string nk, bool? refresh = null)

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
    public class PortalsIdDesignsNkCustomerGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation customer.
                Customer result = apiInstance.PortalsIdDesignsNkCustomerGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkCustomerGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkexportscountget"></a>
# **PortalsIdDesignsNkExportsCountGet**
> InlineResponse200 PortalsIdDesignsNkExportsCountGet (string id, string nk, string where = null)

Counts exports of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkExportsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts exports of Design.
                InlineResponse200 result = apiInstance.PortalsIdDesignsNkExportsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkExportsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkexportsdelete"></a>
# **PortalsIdDesignsNkExportsDelete**
> void PortalsIdDesignsNkExportsDelete (string id, string nk)

Deletes all exports of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkExportsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.

            try
            {
                // Deletes all exports of this model.
                apiInstance.PortalsIdDesignsNkExportsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkExportsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkexportsfkdelete"></a>
# **PortalsIdDesignsNkExportsFkDelete**
> void PortalsIdDesignsNkExportsFkDelete (string id, string nk, string fk)

Delete a related item by id for exports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkExportsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for exports

            try
            {
                // Delete a related item by id for exports.
                apiInstance.PortalsIdDesignsNkExportsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkExportsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for exports | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkexportsfkget"></a>
# **PortalsIdDesignsNkExportsFkGet**
> DesignExport PortalsIdDesignsNkExportsFkGet (string id, string nk, string fk)

Find a related item by id for exports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkExportsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for exports

            try
            {
                // Find a related item by id for exports.
                DesignExport result = apiInstance.PortalsIdDesignsNkExportsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkExportsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for exports | 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkexportsfkput"></a>
# **PortalsIdDesignsNkExportsFkPut**
> DesignExport PortalsIdDesignsNkExportsFkPut (string id, string nk, string fk, DesignExport data = null)

Update a related item by id for exports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkExportsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for exports
            var data = new DesignExport(); // DesignExport |  (optional) 

            try
            {
                // Update a related item by id for exports.
                DesignExport result = apiInstance.PortalsIdDesignsNkExportsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkExportsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for exports | 
 **data** | [**DesignExport**](DesignExport.md)|  | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkexportsget"></a>
# **PortalsIdDesignsNkExportsGet**
> List<DesignExport> PortalsIdDesignsNkExportsGet (string id, string nk, string filter = null)

Queries exports of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkExportsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries exports of Design.
                List&lt;DesignExport&gt; result = apiInstance.PortalsIdDesignsNkExportsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkExportsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignExport>**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkexportspost"></a>
# **PortalsIdDesignsNkExportsPost**
> DesignExport PortalsIdDesignsNkExportsPost (string id, string nk, DesignExport data = null)

Creates a new instance in exports of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkExportsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var data = new DesignExport(); // DesignExport |  (optional) 

            try
            {
                // Creates a new instance in exports of this model.
                DesignExport result = apiInstance.PortalsIdDesignsNkExportsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkExportsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **data** | [**DesignExport**](DesignExport.md)|  | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkfolderget"></a>
# **PortalsIdDesignsNkFolderGet**
> DesignFolder PortalsIdDesignsNkFolderGet (string id, string nk, bool? refresh = null)

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
    public class PortalsIdDesignsNkFolderGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation folder.
                DesignFolder result = apiInstance.PortalsIdDesignsNkFolderGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkFolderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkportalget"></a>
# **PortalsIdDesignsNkPortalGet**
> Portal PortalsIdDesignsNkPortalGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkPortalGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation portal.
                Portal result = apiInstance.PortalsIdDesignsNkPortalGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkPortalGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkrequesterget"></a>
# **PortalsIdDesignsNkRequesterGet**
> TeamMember PortalsIdDesignsNkRequesterGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation requester.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkRequesterGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation requester.
                TeamMember result = apiInstance.PortalsIdDesignsNkRequesterGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkRequesterGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnkreviewerget"></a>
# **PortalsIdDesignsNkReviewerGet**
> TeamMember PortalsIdDesignsNkReviewerGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation reviewer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkReviewerGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation reviewer.
                TeamMember result = apiInstance.PortalsIdDesignsNkReviewerGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkReviewerGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagscountget"></a>
# **PortalsIdDesignsNkTagsCountGet**
> InlineResponse200 PortalsIdDesignsNkTagsCountGet (string id, string nk, string where = null)

Counts tags of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkTagsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts tags of Design.
                InlineResponse200 result = apiInstance.PortalsIdDesignsNkTagsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagsdelete"></a>
# **PortalsIdDesignsNkTagsDelete**
> void PortalsIdDesignsNkTagsDelete (string id, string nk)

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
    public class PortalsIdDesignsNkTagsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.

            try
            {
                // Deletes all tags of this model.
                apiInstance.PortalsIdDesignsNkTagsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagsfkdelete"></a>
# **PortalsIdDesignsNkTagsFkDelete**
> void PortalsIdDesignsNkTagsFkDelete (string id, string nk, string fk)

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
    public class PortalsIdDesignsNkTagsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Delete a related item by id for tags.
                apiInstance.PortalsIdDesignsNkTagsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for tags | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagsfkget"></a>
# **PortalsIdDesignsNkTagsFkGet**
> Tag PortalsIdDesignsNkTagsFkGet (string id, string nk, string fk)

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
    public class PortalsIdDesignsNkTagsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Find a related item by id for tags.
                Tag result = apiInstance.PortalsIdDesignsNkTagsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for tags | 

### Return type

[**Tag**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagsfkput"></a>
# **PortalsIdDesignsNkTagsFkPut**
> Tag PortalsIdDesignsNkTagsFkPut (string id, string nk, string fk, Tag data = null)

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
    public class PortalsIdDesignsNkTagsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for tags
            var data = new Tag(); // Tag |  (optional) 

            try
            {
                // Update a related item by id for tags.
                Tag result = apiInstance.PortalsIdDesignsNkTagsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
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

<a name="portalsiddesignsnktagsget"></a>
# **PortalsIdDesignsNkTagsGet**
> List<Tag> PortalsIdDesignsNkTagsGet (string id, string nk, string filter = null)

Queries tags of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkTagsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries tags of Design.
                List&lt;Tag&gt; result = apiInstance.PortalsIdDesignsNkTagsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Tag>**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagspost"></a>
# **PortalsIdDesignsNkTagsPost**
> Tag PortalsIdDesignsNkTagsPost (string id, string nk, Tag data = null)

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
    public class PortalsIdDesignsNkTagsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var data = new Tag(); // Tag |  (optional) 

            try
            {
                // Creates a new instance in tags of this model.
                Tag result = apiInstance.PortalsIdDesignsNkTagsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **data** | [**Tag**](Tag.md)|  | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagsrelfkdelete"></a>
# **PortalsIdDesignsNkTagsRelFkDelete**
> void PortalsIdDesignsNkTagsRelFkDelete (string id, string nk, string fk)

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
    public class PortalsIdDesignsNkTagsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Remove the tags relation to an item by id.
                apiInstance.PortalsIdDesignsNkTagsRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for tags | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagsrelfkhead"></a>
# **PortalsIdDesignsNkTagsRelFkHead**
> bool? PortalsIdDesignsNkTagsRelFkHead (string id, string nk, string fk)

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
    public class PortalsIdDesignsNkTagsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Check the existence of tags relation to an item by id.
                bool? result = apiInstance.PortalsIdDesignsNkTagsRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for tags | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktagsrelfkput"></a>
# **PortalsIdDesignsNkTagsRelFkPut**
> DesignTag PortalsIdDesignsNkTagsRelFkPut (string id, string nk, string fk, DesignTag data = null)

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
    public class PortalsIdDesignsNkTagsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var fk = fk_example;  // string | Foreign key for tags
            var data = new DesignTag(); // DesignTag |  (optional) 

            try
            {
                // Add a related item by id for tags.
                DesignTag result = apiInstance.PortalsIdDesignsNkTagsRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTagsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **fk** | **string**| Foreign key for tags | 
 **data** | [**DesignTag**](DesignTag.md)|  | [optional] 

### Return type

[**DesignTag**](DesignTag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignsnktemplateget"></a>
# **PortalsIdDesignsNkTemplateGet**
> Template PortalsIdDesignsNkTemplateGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdDesignsNkTemplateGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var nk = nk_example;  // string | Foreign key for designs.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation template.
                Template result = apiInstance.PortalsIdDesignsNkTemplateGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsNkTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **nk** | **string**| Foreign key for designs. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsiddesignspost"></a>
# **PortalsIdDesignsPost**
> Design PortalsIdDesignsPost (string id, Design data = null)

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
    public class PortalsIdDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in designs of this model.
                Design result = apiInstance.PortalsIdDesignsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidexistsget"></a>
# **PortalsIdExistsGet**
> InlineResponse2002 PortalsIdExistsGet (string id)

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
    public class PortalsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.PortalsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdExistsGet: " + e.Message );
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

<a name="portalsidget"></a>
# **PortalsIdGet**
> Portal PortalsIdGet (string id, string filter = null)

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
    public class PortalsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                Portal result = apiInstance.PortalsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdGet: " + e.Message );
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

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidhead"></a>
# **PortalsIdHead**
> InlineResponse2002 PortalsIdHead (string id)

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
    public class PortalsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.PortalsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdHead: " + e.Message );
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

<a name="portalsidimagefolderscountget"></a>
# **PortalsIdImageFoldersCountGet**
> InlineResponse200 PortalsIdImageFoldersCountGet (string id, string where = null)

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
    public class PortalsIdImageFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts imageFolders of Portal.
                InlineResponse200 result = apiInstance.PortalsIdImageFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidimagefoldersdelete"></a>
# **PortalsIdImageFoldersDelete**
> void PortalsIdImageFoldersDelete (string id)

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
    public class PortalsIdImageFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id

            try
            {
                // Deletes all imageFolders of this model.
                apiInstance.PortalsIdImageFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidimagefoldersfkdelete"></a>
# **PortalsIdImageFoldersFkDelete**
> void PortalsIdImageFoldersFkDelete (string id, string fk)

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
    public class PortalsIdImageFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Delete a related item by id for imageFolders.
                apiInstance.PortalsIdImageFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidimagefoldersfkget"></a>
# **PortalsIdImageFoldersFkGet**
> ImageFolder PortalsIdImageFoldersFkGet (string id, string fk)

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
    public class PortalsIdImageFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Find a related item by id for imageFolders.
                ImageFolder result = apiInstance.PortalsIdImageFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidimagefoldersfkput"></a>
# **PortalsIdImageFoldersFkPut**
> ImageFolder PortalsIdImageFoldersFkPut (string id, string fk, ImageFolder data = null)

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
    public class PortalsIdImageFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Update a related item by id for imageFolders.
                ImageFolder result = apiInstance.PortalsIdImageFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsidimagefoldersget"></a>
# **PortalsIdImageFoldersGet**
> List<ImageFolder> PortalsIdImageFoldersGet (string id, string filter = null)

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
    public class PortalsIdImageFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries imageFolders of Portal.
                List&lt;ImageFolder&gt; result = apiInstance.PortalsIdImageFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ImageFolder>**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidimagefolderspost"></a>
# **PortalsIdImageFoldersPost**
> ImageFolder PortalsIdImageFoldersPost (string id, ImageFolder data = null)

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
    public class PortalsIdImageFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new ImageFolder(); // ImageFolder |  (optional) 

            try
            {
                // Creates a new instance in imageFolders of this model.
                ImageFolder result = apiInstance.PortalsIdImageFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**ImageFolder**](ImageFolder.md)|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidimagefoldersrelfkdelete"></a>
# **PortalsIdImageFoldersRelFkDelete**
> void PortalsIdImageFoldersRelFkDelete (string id, string fk)

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
    public class PortalsIdImageFoldersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Remove the imageFolders relation to an item by id.
                apiInstance.PortalsIdImageFoldersRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidimagefoldersrelfkhead"></a>
# **PortalsIdImageFoldersRelFkHead**
> bool? PortalsIdImageFoldersRelFkHead (string id, string fk)

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
    public class PortalsIdImageFoldersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for imageFolders

            try
            {
                // Check the existence of imageFolders relation to an item by id.
                bool? result = apiInstance.PortalsIdImageFoldersRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for imageFolders | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidimagefoldersrelfkput"></a>
# **PortalsIdImageFoldersRelFkPut**
> PortalImageFolder PortalsIdImageFoldersRelFkPut (string id, string fk, PortalImageFolder data = null)

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
    public class PortalsIdImageFoldersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for imageFolders
            var data = new PortalImageFolder(); // PortalImageFolder |  (optional) 

            try
            {
                // Add a related item by id for imageFolders.
                PortalImageFolder result = apiInstance.PortalsIdImageFoldersRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdImageFoldersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsidinvitationticketsfkdelete"></a>
# **PortalsIdInvitationTicketsFkDelete**
> Object PortalsIdInvitationTicketsFkDelete (string id, string id2, string fk)

Delete InvitationTickets for this Portal

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdInvitationTicketsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | Portal id
            var fk = fk_example;  // string | InvitationTicket id

            try
            {
                // Delete InvitationTickets for this Portal
                Object result = apiInstance.PortalsIdInvitationTicketsFkDelete(id, id2, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdInvitationTicketsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**| Portal id | 
 **fk** | **string**| InvitationTicket id | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidinvitationticketsfkget"></a>
# **PortalsIdInvitationTicketsFkGet**
> InvitationTicket PortalsIdInvitationTicketsFkGet (string id, string id2, string fk, string filter = null)

Get InvitationTicket by Id for this Portal

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdInvitationTicketsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | Portal id
            var fk = fk_example;  // string | InvitationTicket id
            var filter = filter_example;  // string | Only include changes that match this filter (optional) 

            try
            {
                // Get InvitationTicket by Id for this Portal
                InvitationTicket result = apiInstance.PortalsIdInvitationTicketsFkGet(id, id2, fk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdInvitationTicketsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**| Portal id | 
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

<a name="portalsidinvitationticketsget"></a>
# **PortalsIdInvitationTicketsGet**
> List<InvitationTicket> PortalsIdInvitationTicketsGet (string id, string id2, string filter = null)

List InvitationTickets for this Portal

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdInvitationTicketsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | Portal id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // List InvitationTickets for this Portal
                List&lt;InvitationTicket&gt; result = apiInstance.PortalsIdInvitationTicketsGet(id, id2, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdInvitationTicketsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**| Portal id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<InvitationTicket>**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidlogoput"></a>
# **PortalsIdLogoPut**
> Portal PortalsIdLogoPut (string id, string id2, Portal data)

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
    public class PortalsIdLogoPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | Portal id
            var data = new Portal(); // Portal | Logo

            try
            {
                // Change logo
                Portal result = apiInstance.PortalsIdLogoPut(id, id2, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdLogoPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**| Portal id | 
 **data** | [**Portal**](Portal.md)| Logo | 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmemberscountget"></a>
# **PortalsIdMembersCountGet**
> InlineResponse200 PortalsIdMembersCountGet (string id, string where = null)

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
    public class PortalsIdMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts members of Portal.
                InlineResponse200 result = apiInstance.PortalsIdMembersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmembersdelete"></a>
# **PortalsIdMembersDelete**
> void PortalsIdMembersDelete (string id)

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
    public class PortalsIdMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id

            try
            {
                // Deletes all members of this model.
                apiInstance.PortalsIdMembersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmembersfkdelete"></a>
# **PortalsIdMembersFkDelete**
> void PortalsIdMembersFkDelete (string id, string fk)

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
    public class PortalsIdMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Delete a related item by id for members.
                apiInstance.PortalsIdMembersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmembersfkget"></a>
# **PortalsIdMembersFkGet**
> TeamMember PortalsIdMembersFkGet (string id, string fk)

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
    public class PortalsIdMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Find a related item by id for members.
                TeamMember result = apiInstance.PortalsIdMembersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for members | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmembersfkput"></a>
# **PortalsIdMembersFkPut**
> TeamMember PortalsIdMembersFkPut (string id, string fk, TeamMember data = null)

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
    public class PortalsIdMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for members
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for members.
                TeamMember result = apiInstance.PortalsIdMembersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsidmembersget"></a>
# **PortalsIdMembersGet**
> List<TeamMember> PortalsIdMembersGet (string id, string filter = null)

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
    public class PortalsIdMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries members of Portal.
                List&lt;TeamMember&gt; result = apiInstance.PortalsIdMembersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmemberspost"></a>
# **PortalsIdMembersPost**
> TeamMember PortalsIdMembersPost (string id, TeamMember data = null)

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
    public class PortalsIdMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in members of this model.
                TeamMember result = apiInstance.PortalsIdMembersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmembersrelfkdelete"></a>
# **PortalsIdMembersRelFkDelete**
> void PortalsIdMembersRelFkDelete (string id, string fk)

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
    public class PortalsIdMembersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Remove the members relation to an item by id.
                apiInstance.PortalsIdMembersRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for members | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmembersrelfkhead"></a>
# **PortalsIdMembersRelFkHead**
> bool? PortalsIdMembersRelFkHead (string id, string fk)

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
    public class PortalsIdMembersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for members

            try
            {
                // Check the existence of members relation to an item by id.
                bool? result = apiInstance.PortalsIdMembersRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for members | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidmembersrelfkput"></a>
# **PortalsIdMembersRelFkPut**
> PortalMember PortalsIdMembersRelFkPut (string id, string fk, PortalMember data = null)

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
    public class PortalsIdMembersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for members
            var data = new PortalMember(); // PortalMember |  (optional) 

            try
            {
                // Add a related item by id for members.
                PortalMember result = apiInstance.PortalsIdMembersRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdMembersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsidpatch"></a>
# **PortalsIdPatch**
> Portal PortalsIdPatch (string id, Portal data = null)

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
    public class PortalsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new Portal(); // Portal | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                Portal result = apiInstance.PortalsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**Portal**](Portal.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidportalmemberscountget"></a>
# **PortalsIdPortalMembersCountGet**
> InlineResponse200 PortalsIdPortalMembersCountGet (string id, string where = null)

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
    public class PortalsIdPortalMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts portalMembers of Portal.
                InlineResponse200 result = apiInstance.PortalsIdPortalMembersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPortalMembersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidportalmembersdelete"></a>
# **PortalsIdPortalMembersDelete**
> void PortalsIdPortalMembersDelete (string id)

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
    public class PortalsIdPortalMembersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id

            try
            {
                // Deletes all portalMembers of this model.
                apiInstance.PortalsIdPortalMembersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPortalMembersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidportalmembersfkdelete"></a>
# **PortalsIdPortalMembersFkDelete**
> void PortalsIdPortalMembersFkDelete (string id, string fk)

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
    public class PortalsIdPortalMembersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for portalMembers

            try
            {
                // Delete a related item by id for portalMembers.
                apiInstance.PortalsIdPortalMembersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPortalMembersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for portalMembers | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidportalmembersfkget"></a>
# **PortalsIdPortalMembersFkGet**
> PortalMember PortalsIdPortalMembersFkGet (string id, string fk)

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
    public class PortalsIdPortalMembersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for portalMembers

            try
            {
                // Find a related item by id for portalMembers.
                PortalMember result = apiInstance.PortalsIdPortalMembersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPortalMembersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for portalMembers | 

### Return type

[**PortalMember**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidportalmembersfkput"></a>
# **PortalsIdPortalMembersFkPut**
> PortalMember PortalsIdPortalMembersFkPut (string id, string fk, PortalMember data = null)

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
    public class PortalsIdPortalMembersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for portalMembers
            var data = new PortalMember(); // PortalMember |  (optional) 

            try
            {
                // Update a related item by id for portalMembers.
                PortalMember result = apiInstance.PortalsIdPortalMembersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPortalMembersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsidportalmembersget"></a>
# **PortalsIdPortalMembersGet**
> List<PortalMember> PortalsIdPortalMembersGet (string id, string filter = null)

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
    public class PortalsIdPortalMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries portalMembers of Portal.
                List&lt;PortalMember&gt; result = apiInstance.PortalsIdPortalMembersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPortalMembersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<PortalMember>**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidportalmemberspost"></a>
# **PortalsIdPortalMembersPost**
> PortalMember PortalsIdPortalMembersPost (string id, PortalMember data = null)

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
    public class PortalsIdPortalMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new PortalMember(); // PortalMember |  (optional) 

            try
            {
                // Creates a new instance in portalMembers of this model.
                PortalMember result = apiInstance.PortalsIdPortalMembersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPortalMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**PortalMember**](PortalMember.md)|  | [optional] 

### Return type

[**PortalMember**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidput"></a>
# **PortalsIdPut**
> Portal PortalsIdPut (string id, Portal data = null)

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
    public class PortalsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Model id
            var data = new Portal(); // Portal | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Portal result = apiInstance.PortalsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Portal**](Portal.md)| Model instance data | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidreplacepost"></a>
# **PortalsIdReplacePost**
> Portal PortalsIdReplacePost (string id, Portal data = null)

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
    public class PortalsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Model id
            var data = new Portal(); // Portal | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Portal result = apiInstance.PortalsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Portal**](Portal.md)| Model instance data | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidteamget"></a>
# **PortalsIdTeamGet**
> Team PortalsIdTeamGet (string id, bool? refresh = null)

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
    public class PortalsIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.PortalsIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefolderscountget"></a>
# **PortalsIdTemplateFoldersCountGet**
> InlineResponse200 PortalsIdTemplateFoldersCountGet (string id, string where = null)

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
    public class PortalsIdTemplateFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templateFolders of Portal.
                InlineResponse200 result = apiInstance.PortalsIdTemplateFoldersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefoldersdelete"></a>
# **PortalsIdTemplateFoldersDelete**
> void PortalsIdTemplateFoldersDelete (string id)

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
    public class PortalsIdTemplateFoldersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id

            try
            {
                // Deletes all templateFolders of this model.
                apiInstance.PortalsIdTemplateFoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefoldersfkdelete"></a>
# **PortalsIdTemplateFoldersFkDelete**
> void PortalsIdTemplateFoldersFkDelete (string id, string fk)

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
    public class PortalsIdTemplateFoldersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Delete a related item by id for templateFolders.
                apiInstance.PortalsIdTemplateFoldersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefoldersfkget"></a>
# **PortalsIdTemplateFoldersFkGet**
> PortalTemplateFolder PortalsIdTemplateFoldersFkGet (string id, string fk)

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
    public class PortalsIdTemplateFoldersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templateFolders

            try
            {
                // Find a related item by id for templateFolders.
                PortalTemplateFolder result = apiInstance.PortalsIdTemplateFoldersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for templateFolders | 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefoldersfkput"></a>
# **PortalsIdTemplateFoldersFkPut**
> PortalTemplateFolder PortalsIdTemplateFoldersFkPut (string id, string fk, PortalTemplateFolder data = null)

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
    public class PortalsIdTemplateFoldersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templateFolders
            var data = new PortalTemplateFolder(); // PortalTemplateFolder |  (optional) 

            try
            {
                // Update a related item by id for templateFolders.
                PortalTemplateFolder result = apiInstance.PortalsIdTemplateFoldersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsidtemplatefoldersget"></a>
# **PortalsIdTemplateFoldersGet**
> List<PortalTemplateFolder> PortalsIdTemplateFoldersGet (string id, string filter = null)

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
    public class PortalsIdTemplateFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templateFolders of Portal.
                List&lt;PortalTemplateFolder&gt; result = apiInstance.PortalsIdTemplateFoldersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<PortalTemplateFolder>**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefoldersnktemplatesfkreldelete"></a>
# **PortalsIdTemplateFoldersNkTemplatesFkRelDelete**
> PortalTemplate PortalsIdTemplateFoldersNkTemplatesFkRelDelete (string id, string id2, string nk, string fk)

Unlink folder with Template and Portal

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdTemplateFoldersNkTemplatesFkRelDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | Portal id
            var nk = nk_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Template id

            try
            {
                // Unlink folder with Template and Portal
                PortalTemplate result = apiInstance.PortalsIdTemplateFoldersNkTemplatesFkRelDelete(id, id2, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersNkTemplatesFkRelDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**| Portal id | 
 **nk** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Template id | 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefoldersnktemplatesfkrelput"></a>
# **PortalsIdTemplateFoldersNkTemplatesFkRelPut**
> PortalTemplate PortalsIdTemplateFoldersNkTemplatesFkRelPut (string id, string id2, string nk, string fk)

Link folder with Template and Portal

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdTemplateFoldersNkTemplatesFkRelPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | Portal id
            var nk = nk_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Template id

            try
            {
                // Link folder with Template and Portal
                PortalTemplate result = apiInstance.PortalsIdTemplateFoldersNkTemplatesFkRelPut(id, id2, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersNkTemplatesFkRelPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**| Portal id | 
 **nk** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Template id | 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefolderspost"></a>
# **PortalsIdTemplateFoldersPost**
> PortalTemplateFolder PortalsIdTemplateFoldersPost (string id, PortalTemplateFolder data = null)

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
    public class PortalsIdTemplateFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new PortalTemplateFolder(); // PortalTemplateFolder |  (optional) 

            try
            {
                // Creates a new instance in templateFolders of this model.
                PortalTemplateFolder result = apiInstance.PortalsIdTemplateFoldersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)|  | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatefoldersroottemplatesget"></a>
# **PortalsIdTemplateFoldersRootTemplatesGet**
> List<PortalTemplate> PortalsIdTemplateFoldersRootTemplatesGet (string id, string id2, string filter = null)

List templates on root folder

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdTemplateFoldersRootTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | Portal id
            var filter = filter_example;  // string | Only include changes that match this filter (optional) 

            try
            {
                // List templates on root folder
                List&lt;PortalTemplate&gt; result = apiInstance.PortalsIdTemplateFoldersRootTemplatesGet(id, id2, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateFoldersRootTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**| Portal id | 
 **filter** | **string**| Only include changes that match this filter | [optional] 

### Return type

[**List<PortalTemplate>**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplaterelscountget"></a>
# **PortalsIdTemplateRelsCountGet**
> InlineResponse200 PortalsIdTemplateRelsCountGet (string id, string where = null)

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
    public class PortalsIdTemplateRelsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templateRels of Portal.
                InlineResponse200 result = apiInstance.PortalsIdTemplateRelsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateRelsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplaterelsdelete"></a>
# **PortalsIdTemplateRelsDelete**
> void PortalsIdTemplateRelsDelete (string id)

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
    public class PortalsIdTemplateRelsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id

            try
            {
                // Deletes all templateRels of this model.
                apiInstance.PortalsIdTemplateRelsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateRelsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplaterelsfkdelete"></a>
# **PortalsIdTemplateRelsFkDelete**
> void PortalsIdTemplateRelsFkDelete (string id, string fk)

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
    public class PortalsIdTemplateRelsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templateRels

            try
            {
                // Delete a related item by id for templateRels.
                apiInstance.PortalsIdTemplateRelsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateRelsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for templateRels | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplaterelsfkget"></a>
# **PortalsIdTemplateRelsFkGet**
> PortalTemplate PortalsIdTemplateRelsFkGet (string id, string fk)

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
    public class PortalsIdTemplateRelsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templateRels

            try
            {
                // Find a related item by id for templateRels.
                PortalTemplate result = apiInstance.PortalsIdTemplateRelsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateRelsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for templateRels | 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplaterelsfkput"></a>
# **PortalsIdTemplateRelsFkPut**
> PortalTemplate PortalsIdTemplateRelsFkPut (string id, string fk, PortalTemplate data = null)

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
    public class PortalsIdTemplateRelsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templateRels
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Update a related item by id for templateRels.
                PortalTemplate result = apiInstance.PortalsIdTemplateRelsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateRelsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsidtemplaterelsget"></a>
# **PortalsIdTemplateRelsGet**
> List<PortalTemplate> PortalsIdTemplateRelsGet (string id, string filter = null)

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
    public class PortalsIdTemplateRelsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templateRels of Portal.
                List&lt;PortalTemplate&gt; result = apiInstance.PortalsIdTemplateRelsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateRelsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<PortalTemplate>**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplaterelspost"></a>
# **PortalsIdTemplateRelsPost**
> PortalTemplate PortalsIdTemplateRelsPost (string id, PortalTemplate data = null)

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
    public class PortalsIdTemplateRelsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Creates a new instance in templateRels of this model.
                PortalTemplate result = apiInstance.PortalsIdTemplateRelsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplateRelsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**PortalTemplate**](PortalTemplate.md)|  | [optional] 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatescountget"></a>
# **PortalsIdTemplatesCountGet**
> InlineResponse200 PortalsIdTemplatesCountGet (string id, string where = null)

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
    public class PortalsIdTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of Portal.
                InlineResponse200 result = apiInstance.PortalsIdTemplatesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesdelete"></a>
# **PortalsIdTemplatesDelete**
> void PortalsIdTemplatesDelete (string id)

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
    public class PortalsIdTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id

            try
            {
                // Deletes all templates of this model.
                apiInstance.PortalsIdTemplatesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesfkdelete"></a>
# **PortalsIdTemplatesFkDelete**
> void PortalsIdTemplatesFkDelete (string id, string fk)

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
    public class PortalsIdTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.PortalsIdTemplatesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesfkdesignsgeneratebulkpost"></a>
# **PortalsIdTemplatesFkDesignsGenerateBulkPost**
> List<Design> PortalsIdTemplatesFkDesignsGenerateBulkPost (string id, string id2, string fk, List<XAny> data = null)

Generate Design from Template

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdTemplatesFkDesignsGenerateBulkPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | 
            var fk = fk_example;  // string | 
            var data = new List<XAny>(); // List<XAny> |  (optional) 

            try
            {
                // Generate Design from Template
                List&lt;Design&gt; result = apiInstance.PortalsIdTemplatesFkDesignsGenerateBulkPost(id, id2, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesFkDesignsGenerateBulkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**|  | 
 **fk** | **string**|  | 
 **data** | [**List<XAny>**](XAny.md)|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesfkdesignsgeneratepost"></a>
# **PortalsIdTemplatesFkDesignsGeneratePost**
> Design PortalsIdTemplatesFkDesignsGeneratePost (string id, string id2, string fk, Portal data = null)

Generate Design from Template

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalsIdTemplatesFkDesignsGeneratePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var id2 = id_example;  // string | 
            var fk = fk_example;  // string | 
            var data = new Portal(); // Portal |  (optional) 

            try
            {
                // Generate Design from Template
                Design result = apiInstance.PortalsIdTemplatesFkDesignsGeneratePost(id, id2, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesFkDesignsGeneratePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **id2** | **string**|  | 
 **fk** | **string**|  | 
 **data** | [**Portal**](Portal.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesfkget"></a>
# **PortalsIdTemplatesFkGet**
> Template PortalsIdTemplatesFkGet (string id, string fk)

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
    public class PortalsIdTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.PortalsIdTemplatesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesfkput"></a>
# **PortalsIdTemplatesFkPut**
> Template PortalsIdTemplatesFkPut (string id, string fk, Template data = null)

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
    public class PortalsIdTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.PortalsIdTemplatesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalsidtemplatesget"></a>
# **PortalsIdTemplatesGet**
> List<Template> PortalsIdTemplatesGet (string id, string filter = null)

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
    public class PortalsIdTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of Portal.
                List&lt;Template&gt; result = apiInstance.PortalsIdTemplatesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatespost"></a>
# **PortalsIdTemplatesPost**
> Template PortalsIdTemplatesPost (string id, Template data = null)

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
    public class PortalsIdTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.PortalsIdTemplatesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesrelfkdelete"></a>
# **PortalsIdTemplatesRelFkDelete**
> void PortalsIdTemplatesRelFkDelete (string id, string fk)

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
    public class PortalsIdTemplatesRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Remove the templates relation to an item by id.
                apiInstance.PortalsIdTemplatesRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesrelfkhead"></a>
# **PortalsIdTemplatesRelFkHead**
> bool? PortalsIdTemplatesRelFkHead (string id, string fk)

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
    public class PortalsIdTemplatesRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Check the existence of templates relation to an item by id.
                bool? result = apiInstance.PortalsIdTemplatesRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsidtemplatesrelfkput"></a>
# **PortalsIdTemplatesRelFkPut**
> PortalTemplate PortalsIdTemplatesRelFkPut (string id, string fk, PortalTemplate data = null)

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
    public class PortalsIdTemplatesRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var id = id_example;  // string | Portal id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Add a related item by id for templates.
                PortalTemplate result = apiInstance.PortalsIdTemplatesRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsIdTemplatesRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Portal id | 
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

<a name="portalspatch"></a>
# **PortalsPatch**
> Portal PortalsPatch (Portal data = null)

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
    public class PortalsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var data = new Portal(); // Portal | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                Portal result = apiInstance.PortalsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Portal**](Portal.md)| Model instance data | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalspost"></a>
# **PortalsPost**
> Portal PortalsPost (Portal data = null)

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
    public class PortalsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var data = new Portal(); // Portal | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                Portal result = apiInstance.PortalsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Portal**](Portal.md)| Model instance data | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsput"></a>
# **PortalsPut**
> Portal PortalsPut (Portal data = null)

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
    public class PortalsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var data = new Portal(); // Portal | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Portal result = apiInstance.PortalsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Portal**](Portal.md)| Model instance data | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsreplaceorcreatepost"></a>
# **PortalsReplaceOrCreatePost**
> Portal PortalsReplaceOrCreatePost (Portal data = null)

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
    public class PortalsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var data = new Portal(); // Portal | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Portal result = apiInstance.PortalsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Portal**](Portal.md)| Model instance data | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsupdatepost"></a>
# **PortalsUpdatePost**
> InlineResponse2001 PortalsUpdatePost (string where = null, Portal data = null)

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
    public class PortalsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Portal(); // Portal | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2001 result = apiInstance.PortalsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Portal**](Portal.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portalsupsertwithwherepost"></a>
# **PortalsUpsertWithWherePost**
> Portal PortalsUpsertWithWherePost (string where = null, Portal data = null)

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
    public class PortalsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Portal(); // Portal | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                Portal result = apiInstance.PortalsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalApi.PortalsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Portal**](Portal.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

