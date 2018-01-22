# TweakApi.Api.TeamBuilderConfigApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamBuilderConfigsChangeStreamGet**](TeamBuilderConfigApi.md#teambuilderconfigschangestreamget) | **GET** /TeamBuilderConfigs/change-stream | Create a change stream.
[**TeamBuilderConfigsChangeStreamPost**](TeamBuilderConfigApi.md#teambuilderconfigschangestreampost) | **POST** /TeamBuilderConfigs/change-stream | Create a change stream.
[**TeamBuilderConfigsCountGet**](TeamBuilderConfigApi.md#teambuilderconfigscountget) | **GET** /TeamBuilderConfigs/count | Count instances of the model matched by where from the data source.
[**TeamBuilderConfigsFindOneGet**](TeamBuilderConfigApi.md#teambuilderconfigsfindoneget) | **GET** /TeamBuilderConfigs/findOne | Find first instance of the model matched by filter from the data source.
[**TeamBuilderConfigsGet**](TeamBuilderConfigApi.md#teambuilderconfigsget) | **GET** /TeamBuilderConfigs | Find all instances of the model matched by filter from the data source.
[**TeamBuilderConfigsIdDelete**](TeamBuilderConfigApi.md#teambuilderconfigsiddelete) | **DELETE** /TeamBuilderConfigs/{id} | Delete a model instance by {{id}} from the data source.
[**TeamBuilderConfigsIdExistsGet**](TeamBuilderConfigApi.md#teambuilderconfigsidexistsget) | **GET** /TeamBuilderConfigs/{id}/exists | Check whether a model instance exists in the data source.
[**TeamBuilderConfigsIdGet**](TeamBuilderConfigApi.md#teambuilderconfigsidget) | **GET** /TeamBuilderConfigs/{id} | Find a model instance by {{id}} from the data source.
[**TeamBuilderConfigsIdHead**](TeamBuilderConfigApi.md#teambuilderconfigsidhead) | **HEAD** /TeamBuilderConfigs/{id} | Check whether a model instance exists in the data source.
[**TeamBuilderConfigsIdPatch**](TeamBuilderConfigApi.md#teambuilderconfigsidpatch) | **PATCH** /TeamBuilderConfigs/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigsIdProductGroupsCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupscountget) | **GET** /TeamBuilderConfigs/{id}/productGroups/count | Counts productGroups of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductGroupsDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsdelete) | **DELETE** /TeamBuilderConfigs/{id}/productGroups | Deletes all productGroups of this model.
[**TeamBuilderConfigsIdProductGroupsFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productGroups/{fk} | Delete a related item by id for productGroups.
[**TeamBuilderConfigsIdProductGroupsFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsfkget) | **GET** /TeamBuilderConfigs/{id}/productGroups/{fk} | Find a related item by id for productGroups.
[**TeamBuilderConfigsIdProductGroupsFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsfkput) | **PUT** /TeamBuilderConfigs/{id}/productGroups/{fk} | Update a related item by id for productGroups.
[**TeamBuilderConfigsIdProductGroupsGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsget) | **GET** /TeamBuilderConfigs/{id}/productGroups | Queries productGroups of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductGroupsNkTypesCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsnktypescountget) | **GET** /TeamBuilderConfigs/{id}/productGroups/{nk}/types/count | Counts types of ProductGroup.
[**TeamBuilderConfigsIdProductGroupsNkTypesDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsnktypesdelete) | **DELETE** /TeamBuilderConfigs/{id}/productGroups/{nk}/types | Deletes all types of this model.
[**TeamBuilderConfigsIdProductGroupsNkTypesFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsnktypesfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productGroups/{nk}/types/{fk} | Delete a related item by id for types.
[**TeamBuilderConfigsIdProductGroupsNkTypesFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsnktypesfkget) | **GET** /TeamBuilderConfigs/{id}/productGroups/{nk}/types/{fk} | Find a related item by id for types.
[**TeamBuilderConfigsIdProductGroupsNkTypesFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsnktypesfkput) | **PUT** /TeamBuilderConfigs/{id}/productGroups/{nk}/types/{fk} | Update a related item by id for types.
[**TeamBuilderConfigsIdProductGroupsNkTypesGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsnktypesget) | **GET** /TeamBuilderConfigs/{id}/productGroups/{nk}/types | Queries types of ProductGroup.
[**TeamBuilderConfigsIdProductGroupsNkTypesPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsnktypespost) | **POST** /TeamBuilderConfigs/{id}/productGroups/{nk}/types | Creates a new instance in types of this model.
[**TeamBuilderConfigsIdProductGroupsPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupspost) | **POST** /TeamBuilderConfigs/{id}/productGroups | Creates a new instance in productGroups of this model.
[**TeamBuilderConfigsIdProductGroupsRelFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsrelfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productGroups/rel/{fk} | Remove the productGroups relation to an item by id.
[**TeamBuilderConfigsIdProductGroupsRelFkHead**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsrelfkhead) | **HEAD** /TeamBuilderConfigs/{id}/productGroups/rel/{fk} | Check the existence of productGroups relation to an item by id.
[**TeamBuilderConfigsIdProductGroupsRelFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductgroupsrelfkput) | **PUT** /TeamBuilderConfigs/{id}/productGroups/rel/{fk} | Add a related item by id for productGroups.
[**TeamBuilderConfigsIdProductSizeMaterialsCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialscountget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterials/count | Counts productSizeMaterials of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductSizeMaterialsDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizeMaterials | Deletes all productSizeMaterials of this model.
[**TeamBuilderConfigsIdProductSizeMaterialsFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizeMaterials/{fk} | Delete a related item by id for productSizeMaterials.
[**TeamBuilderConfigsIdProductSizeMaterialsFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsfkget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterials/{fk} | Find a related item by id for productSizeMaterials.
[**TeamBuilderConfigsIdProductSizeMaterialsFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsfkput) | **PUT** /TeamBuilderConfigs/{id}/productSizeMaterials/{fk} | Update a related item by id for productSizeMaterials.
[**TeamBuilderConfigsIdProductSizeMaterialsGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterials | Queries productSizeMaterials of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductSizeMaterialsNkMaterialGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsnkmaterialget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterials/{nk}/material | Fetches belongsTo relation material.
[**TeamBuilderConfigsIdProductSizeMaterialsNkPdfColorProfileGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsnkpdfcolorprofileget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterials/{nk}/pdfColorProfile | Fetches belongsTo relation pdfColorProfile.
[**TeamBuilderConfigsIdProductSizeMaterialsNkSizeGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsnksizeget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterials/{nk}/size | Fetches belongsTo relation size.
[**TeamBuilderConfigsIdProductSizeMaterialsNkTeamGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsnkteamget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterials/{nk}/team | Fetches belongsTo relation team.
[**TeamBuilderConfigsIdProductSizeMaterialsPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialspost) | **POST** /TeamBuilderConfigs/{id}/productSizeMaterials | Creates a new instance in productSizeMaterials of this model.
[**TeamBuilderConfigsIdProductSizeMaterialsRelCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelcountget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterialsRel/count | Counts productSizeMaterialsRel of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductSizeMaterialsRelDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsreldelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizeMaterialsRel | Deletes all productSizeMaterialsRel of this model.
[**TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizeMaterials/rel/{fk} | Remove the productSizeMaterials relation to an item by id.
[**TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete_0**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelfkdelete_0) | **DELETE** /TeamBuilderConfigs/{id}/productSizeMaterialsRel/{fk} | Delete a related item by id for productSizeMaterialsRel.
[**TeamBuilderConfigsIdProductSizeMaterialsRelFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelfkget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterialsRel/{fk} | Find a related item by id for productSizeMaterialsRel.
[**TeamBuilderConfigsIdProductSizeMaterialsRelFkHead**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelfkhead) | **HEAD** /TeamBuilderConfigs/{id}/productSizeMaterials/rel/{fk} | Check the existence of productSizeMaterials relation to an item by id.
[**TeamBuilderConfigsIdProductSizeMaterialsRelFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelfkput) | **PUT** /TeamBuilderConfigs/{id}/productSizeMaterials/rel/{fk} | Add a related item by id for productSizeMaterials.
[**TeamBuilderConfigsIdProductSizeMaterialsRelFkPut_0**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelfkput_0) | **PUT** /TeamBuilderConfigs/{id}/productSizeMaterialsRel/{fk} | Update a related item by id for productSizeMaterialsRel.
[**TeamBuilderConfigsIdProductSizeMaterialsRelGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterialsRel | Queries productSizeMaterialsRel of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductSizeMaterialsRelNkBuilderConfigGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelnkbuilderconfigget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterialsRel/{nk}/builderConfig | Fetches belongsTo relation builderConfig.
[**TeamBuilderConfigsIdProductSizeMaterialsRelNkPdfColorProfileGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelnkpdfcolorprofileget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterialsRel/{nk}/pdfColorProfile | Fetches belongsTo relation pdfColorProfile.
[**TeamBuilderConfigsIdProductSizeMaterialsRelNkProductSizeMaterialGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelnkproductsizematerialget) | **GET** /TeamBuilderConfigs/{id}/productSizeMaterialsRel/{nk}/productSizeMaterial | Fetches belongsTo relation productSizeMaterial.
[**TeamBuilderConfigsIdProductSizeMaterialsRelPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizematerialsrelpost) | **POST** /TeamBuilderConfigs/{id}/productSizeMaterialsRel | Creates a new instance in productSizeMaterialsRel of this model.
[**TeamBuilderConfigsIdProductSizesCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizescountget) | **GET** /TeamBuilderConfigs/{id}/productSizes/count | Counts productSizes of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductSizesDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes | Deletes all productSizes of this model.
[**TeamBuilderConfigsIdProductSizesFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/{fk} | Delete a related item by id for productSizes.
[**TeamBuilderConfigsIdProductSizesFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesfkget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{fk} | Find a related item by id for productSizes.
[**TeamBuilderConfigsIdProductSizesFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesfkput) | **PUT** /TeamBuilderConfigs/{id}/productSizes/{fk} | Update a related item by id for productSizes.
[**TeamBuilderConfigsIdProductSizesGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesget) | **GET** /TeamBuilderConfigs/{id}/productSizes | Queries productSizes of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductSizesNkMaterialsCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialscountget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials/count | Counts materials of ProductSize.
[**TeamBuilderConfigsIdProductSizesNkMaterialsDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialsdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials | Deletes all materials of this model.
[**TeamBuilderConfigsIdProductSizesNkMaterialsFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialsfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials/{fk} | Delete a related item by id for materials.
[**TeamBuilderConfigsIdProductSizesNkMaterialsFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialsfkget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials/{fk} | Find a related item by id for materials.
[**TeamBuilderConfigsIdProductSizesNkMaterialsFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialsfkput) | **PUT** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials/{fk} | Update a related item by id for materials.
[**TeamBuilderConfigsIdProductSizesNkMaterialsGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialsget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials | Queries materials of ProductSize.
[**TeamBuilderConfigsIdProductSizesNkMaterialsPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialspost) | **POST** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials | Creates a new instance in materials of this model.
[**TeamBuilderConfigsIdProductSizesNkMaterialsRelFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialsrelfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials/rel/{fk} | Remove the materials relation to an item by id.
[**TeamBuilderConfigsIdProductSizesNkMaterialsRelFkHead**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialsrelfkhead) | **HEAD** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials/rel/{fk} | Check the existence of materials relation to an item by id.
[**TeamBuilderConfigsIdProductSizesNkMaterialsRelFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkmaterialsrelfkput) | **PUT** /TeamBuilderConfigs/{id}/productSizes/{nk}/materials/rel/{fk} | Add a related item by id for materials.
[**TeamBuilderConfigsIdProductSizesNkPdfColorProfileGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkpdfcolorprofileget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/pdfColorProfile | Fetches belongsTo relation pdfColorProfile.
[**TeamBuilderConfigsIdProductSizesNkProductsCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkproductscountget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/products/count | Counts products of ProductSize.
[**TeamBuilderConfigsIdProductSizesNkProductsDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkproductsdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/{nk}/products | Deletes all products of this model.
[**TeamBuilderConfigsIdProductSizesNkProductsFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkproductsfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/{nk}/products/{fk} | Delete a related item by id for products.
[**TeamBuilderConfigsIdProductSizesNkProductsFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkproductsfkget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/products/{fk} | Find a related item by id for products.
[**TeamBuilderConfigsIdProductSizesNkProductsFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkproductsfkput) | **PUT** /TeamBuilderConfigs/{id}/productSizes/{nk}/products/{fk} | Update a related item by id for products.
[**TeamBuilderConfigsIdProductSizesNkProductsGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkproductsget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/products | Queries products of ProductSize.
[**TeamBuilderConfigsIdProductSizesNkProductsPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnkproductspost) | **POST** /TeamBuilderConfigs/{id}/productSizes/{nk}/products | Creates a new instance in products of this model.
[**TeamBuilderConfigsIdProductSizesNkSizeMaterialsCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnksizematerialscountget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/sizeMaterials/count | Counts sizeMaterials of ProductSize.
[**TeamBuilderConfigsIdProductSizesNkSizeMaterialsDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnksizematerialsdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/{nk}/sizeMaterials | Deletes all sizeMaterials of this model.
[**TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnksizematerialsfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/{nk}/sizeMaterials/{fk} | Delete a related item by id for sizeMaterials.
[**TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnksizematerialsfkget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/sizeMaterials/{fk} | Find a related item by id for sizeMaterials.
[**TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnksizematerialsfkput) | **PUT** /TeamBuilderConfigs/{id}/productSizes/{nk}/sizeMaterials/{fk} | Update a related item by id for sizeMaterials.
[**TeamBuilderConfigsIdProductSizesNkSizeMaterialsGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnksizematerialsget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/sizeMaterials | Queries sizeMaterials of ProductSize.
[**TeamBuilderConfigsIdProductSizesNkSizeMaterialsPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnksizematerialspost) | **POST** /TeamBuilderConfigs/{id}/productSizes/{nk}/sizeMaterials | Creates a new instance in sizeMaterials of this model.
[**TeamBuilderConfigsIdProductSizesNkTypeGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesnktypeget) | **GET** /TeamBuilderConfigs/{id}/productSizes/{nk}/type | Fetches belongsTo relation type.
[**TeamBuilderConfigsIdProductSizesPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizespost) | **POST** /TeamBuilderConfigs/{id}/productSizes | Creates a new instance in productSizes of this model.
[**TeamBuilderConfigsIdProductSizesRelFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesrelfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productSizes/rel/{fk} | Remove the productSizes relation to an item by id.
[**TeamBuilderConfigsIdProductSizesRelFkHead**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesrelfkhead) | **HEAD** /TeamBuilderConfigs/{id}/productSizes/rel/{fk} | Check the existence of productSizes relation to an item by id.
[**TeamBuilderConfigsIdProductSizesRelFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproductsizesrelfkput) | **PUT** /TeamBuilderConfigs/{id}/productSizes/rel/{fk} | Add a related item by id for productSizes.
[**TeamBuilderConfigsIdProductTypesCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypescountget) | **GET** /TeamBuilderConfigs/{id}/productTypes/count | Counts productTypes of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductTypesDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesdelete) | **DELETE** /TeamBuilderConfigs/{id}/productTypes | Deletes all productTypes of this model.
[**TeamBuilderConfigsIdProductTypesFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productTypes/{fk} | Delete a related item by id for productTypes.
[**TeamBuilderConfigsIdProductTypesFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesfkget) | **GET** /TeamBuilderConfigs/{id}/productTypes/{fk} | Find a related item by id for productTypes.
[**TeamBuilderConfigsIdProductTypesFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesfkput) | **PUT** /TeamBuilderConfigs/{id}/productTypes/{fk} | Update a related item by id for productTypes.
[**TeamBuilderConfigsIdProductTypesGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesget) | **GET** /TeamBuilderConfigs/{id}/productTypes | Queries productTypes of TeamBuilderConfig.
[**TeamBuilderConfigsIdProductTypesNkGroupGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesnkgroupget) | **GET** /TeamBuilderConfigs/{id}/productTypes/{nk}/group | Fetches belongsTo relation group.
[**TeamBuilderConfigsIdProductTypesNkSizesCountGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesnksizescountget) | **GET** /TeamBuilderConfigs/{id}/productTypes/{nk}/sizes/count | Counts sizes of ProductType.
[**TeamBuilderConfigsIdProductTypesNkSizesDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesnksizesdelete) | **DELETE** /TeamBuilderConfigs/{id}/productTypes/{nk}/sizes | Deletes all sizes of this model.
[**TeamBuilderConfigsIdProductTypesNkSizesFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesnksizesfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productTypes/{nk}/sizes/{fk} | Delete a related item by id for sizes.
[**TeamBuilderConfigsIdProductTypesNkSizesFkGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesnksizesfkget) | **GET** /TeamBuilderConfigs/{id}/productTypes/{nk}/sizes/{fk} | Find a related item by id for sizes.
[**TeamBuilderConfigsIdProductTypesNkSizesFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesnksizesfkput) | **PUT** /TeamBuilderConfigs/{id}/productTypes/{nk}/sizes/{fk} | Update a related item by id for sizes.
[**TeamBuilderConfigsIdProductTypesNkSizesGet**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesnksizesget) | **GET** /TeamBuilderConfigs/{id}/productTypes/{nk}/sizes | Queries sizes of ProductType.
[**TeamBuilderConfigsIdProductTypesNkSizesPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesnksizespost) | **POST** /TeamBuilderConfigs/{id}/productTypes/{nk}/sizes | Creates a new instance in sizes of this model.
[**TeamBuilderConfigsIdProductTypesPost**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypespost) | **POST** /TeamBuilderConfigs/{id}/productTypes | Creates a new instance in productTypes of this model.
[**TeamBuilderConfigsIdProductTypesRelFkDelete**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesrelfkdelete) | **DELETE** /TeamBuilderConfigs/{id}/productTypes/rel/{fk} | Remove the productTypes relation to an item by id.
[**TeamBuilderConfigsIdProductTypesRelFkHead**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesrelfkhead) | **HEAD** /TeamBuilderConfigs/{id}/productTypes/rel/{fk} | Check the existence of productTypes relation to an item by id.
[**TeamBuilderConfigsIdProductTypesRelFkPut**](TeamBuilderConfigApi.md#teambuilderconfigsidproducttypesrelfkput) | **PUT** /TeamBuilderConfigs/{id}/productTypes/rel/{fk} | Add a related item by id for productTypes.
[**TeamBuilderConfigsIdPut**](TeamBuilderConfigApi.md#teambuilderconfigsidput) | **PUT** /TeamBuilderConfigs/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigsIdReplacePost**](TeamBuilderConfigApi.md#teambuilderconfigsidreplacepost) | **POST** /TeamBuilderConfigs/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigsIdTeamGet**](TeamBuilderConfigApi.md#teambuilderconfigsidteamget) | **GET** /TeamBuilderConfigs/{id}/team | Fetches belongsTo relation team.
[**TeamBuilderConfigsPatch**](TeamBuilderConfigApi.md#teambuilderconfigspatch) | **PATCH** /TeamBuilderConfigs | Patch an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigsPost**](TeamBuilderConfigApi.md#teambuilderconfigspost) | **POST** /TeamBuilderConfigs | Create a new instance of the model and persist it into the data source.
[**TeamBuilderConfigsPut**](TeamBuilderConfigApi.md#teambuilderconfigsput) | **PUT** /TeamBuilderConfigs | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigsReplaceOrCreatePost**](TeamBuilderConfigApi.md#teambuilderconfigsreplaceorcreatepost) | **POST** /TeamBuilderConfigs/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigsUpdatePost**](TeamBuilderConfigApi.md#teambuilderconfigsupdatepost) | **POST** /TeamBuilderConfigs/update | Update instances of the model matched by {{where}} from the data source.
[**TeamBuilderConfigsUpsertWithWherePost**](TeamBuilderConfigApi.md#teambuilderconfigsupsertwithwherepost) | **POST** /TeamBuilderConfigs/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teambuilderconfigschangestreamget"></a>
# **TeamBuilderConfigsChangeStreamGet**
> System.IO.Stream TeamBuilderConfigsChangeStreamGet (string options = null)

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
    public class TeamBuilderConfigsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsChangeStreamGet: " + e.Message );
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

<a name="teambuilderconfigschangestreampost"></a>
# **TeamBuilderConfigsChangeStreamPost**
> System.IO.Stream TeamBuilderConfigsChangeStreamPost (string options = null)

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
    public class TeamBuilderConfigsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsChangeStreamPost: " + e.Message );
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

<a name="teambuilderconfigscountget"></a>
# **TeamBuilderConfigsCountGet**
> InlineResponse2001 TeamBuilderConfigsCountGet (string where = null)

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
    public class TeamBuilderConfigsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsCountGet: " + e.Message );
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

<a name="teambuilderconfigsfindoneget"></a>
# **TeamBuilderConfigsFindOneGet**
> TeamBuilderConfig TeamBuilderConfigsFindOneGet (string filter = null)

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
    public class TeamBuilderConfigsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsFindOneGet: " + e.Message );
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

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsget"></a>
# **TeamBuilderConfigsGet**
> List<TeamBuilderConfig> TeamBuilderConfigsGet (string filter = null)

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
    public class TeamBuilderConfigsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TeamBuilderConfig&gt; result = apiInstance.TeamBuilderConfigsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsGet: " + e.Message );
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

[**List<TeamBuilderConfig>**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsiddelete"></a>
# **TeamBuilderConfigsIdDelete**
> Object TeamBuilderConfigsIdDelete (string id)

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
    public class TeamBuilderConfigsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamBuilderConfigsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdDelete: " + e.Message );
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

<a name="teambuilderconfigsidexistsget"></a>
# **TeamBuilderConfigsIdExistsGet**
> InlineResponse2002 TeamBuilderConfigsIdExistsGet (string id)

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
    public class TeamBuilderConfigsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamBuilderConfigsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdExistsGet: " + e.Message );
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

<a name="teambuilderconfigsidget"></a>
# **TeamBuilderConfigsIdGet**
> TeamBuilderConfig TeamBuilderConfigsIdGet (string id, string filter = null)

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
    public class TeamBuilderConfigsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdGet: " + e.Message );
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

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidhead"></a>
# **TeamBuilderConfigsIdHead**
> InlineResponse2002 TeamBuilderConfigsIdHead (string id)

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
    public class TeamBuilderConfigsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamBuilderConfigsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdHead: " + e.Message );
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

<a name="teambuilderconfigsidpatch"></a>
# **TeamBuilderConfigsIdPatch**
> TeamBuilderConfig TeamBuilderConfigsIdPatch (string id, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupscountget"></a>
# **TeamBuilderConfigsIdProductGroupsCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductGroupsCountGet (string id, string where = null)

Counts productGroups of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productGroups of TeamBuilderConfig.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductGroupsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsdelete"></a>
# **TeamBuilderConfigsIdProductGroupsDelete**
> void TeamBuilderConfigsIdProductGroupsDelete (string id)

Deletes all productGroups of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id

            try
            {
                // Deletes all productGroups of this model.
                apiInstance.TeamBuilderConfigsIdProductGroupsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsfkdelete"></a>
# **TeamBuilderConfigsIdProductGroupsFkDelete**
> void TeamBuilderConfigsIdProductGroupsFkDelete (string id, string fk)

Delete a related item by id for productGroups.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productGroups

            try
            {
                // Delete a related item by id for productGroups.
                apiInstance.TeamBuilderConfigsIdProductGroupsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productGroups | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsfkget"></a>
# **TeamBuilderConfigsIdProductGroupsFkGet**
> ProductGroup TeamBuilderConfigsIdProductGroupsFkGet (string id, string fk)

Find a related item by id for productGroups.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productGroups

            try
            {
                // Find a related item by id for productGroups.
                ProductGroup result = apiInstance.TeamBuilderConfigsIdProductGroupsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productGroups | 

### Return type

[**ProductGroup**](ProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsfkput"></a>
# **TeamBuilderConfigsIdProductGroupsFkPut**
> ProductGroup TeamBuilderConfigsIdProductGroupsFkPut (string id, string fk, ProductGroup data = null)

Update a related item by id for productGroups.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productGroups
            var data = new ProductGroup(); // ProductGroup |  (optional) 

            try
            {
                // Update a related item by id for productGroups.
                ProductGroup result = apiInstance.TeamBuilderConfigsIdProductGroupsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productGroups | 
 **data** | [**ProductGroup**](ProductGroup.md)|  | [optional] 

### Return type

[**ProductGroup**](ProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsget"></a>
# **TeamBuilderConfigsIdProductGroupsGet**
> List<ProductGroup> TeamBuilderConfigsIdProductGroupsGet (string id, string filter = null)

Queries productGroups of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productGroups of TeamBuilderConfig.
                List&lt;ProductGroup&gt; result = apiInstance.TeamBuilderConfigsIdProductGroupsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductGroup>**](ProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsnktypescountget"></a>
# **TeamBuilderConfigsIdProductGroupsNkTypesCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductGroupsNkTypesCountGet (string id, string nk, string where = null)

Counts types of ProductGroup.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsNkTypesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productGroups.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts types of ProductGroup.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductGroupsNkTypesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsNkTypesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productGroups. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsnktypesdelete"></a>
# **TeamBuilderConfigsIdProductGroupsNkTypesDelete**
> void TeamBuilderConfigsIdProductGroupsNkTypesDelete (string id, string nk)

Deletes all types of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsNkTypesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productGroups.

            try
            {
                // Deletes all types of this model.
                apiInstance.TeamBuilderConfigsIdProductGroupsNkTypesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsNkTypesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productGroups. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsnktypesfkdelete"></a>
# **TeamBuilderConfigsIdProductGroupsNkTypesFkDelete**
> void TeamBuilderConfigsIdProductGroupsNkTypesFkDelete (string id, string nk, string fk)

Delete a related item by id for types.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsNkTypesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productGroups.
            var fk = fk_example;  // string | Foreign key for types

            try
            {
                // Delete a related item by id for types.
                apiInstance.TeamBuilderConfigsIdProductGroupsNkTypesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsNkTypesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productGroups. | 
 **fk** | **string**| Foreign key for types | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsnktypesfkget"></a>
# **TeamBuilderConfigsIdProductGroupsNkTypesFkGet**
> ProductType TeamBuilderConfigsIdProductGroupsNkTypesFkGet (string id, string nk, string fk)

Find a related item by id for types.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsNkTypesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productGroups.
            var fk = fk_example;  // string | Foreign key for types

            try
            {
                // Find a related item by id for types.
                ProductType result = apiInstance.TeamBuilderConfigsIdProductGroupsNkTypesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsNkTypesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productGroups. | 
 **fk** | **string**| Foreign key for types | 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsnktypesfkput"></a>
# **TeamBuilderConfigsIdProductGroupsNkTypesFkPut**
> ProductType TeamBuilderConfigsIdProductGroupsNkTypesFkPut (string id, string nk, string fk, ProductType data = null)

Update a related item by id for types.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsNkTypesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productGroups.
            var fk = fk_example;  // string | Foreign key for types
            var data = new ProductType(); // ProductType |  (optional) 

            try
            {
                // Update a related item by id for types.
                ProductType result = apiInstance.TeamBuilderConfigsIdProductGroupsNkTypesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsNkTypesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productGroups. | 
 **fk** | **string**| Foreign key for types | 
 **data** | [**ProductType**](ProductType.md)|  | [optional] 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsnktypesget"></a>
# **TeamBuilderConfigsIdProductGroupsNkTypesGet**
> List<ProductType> TeamBuilderConfigsIdProductGroupsNkTypesGet (string id, string nk, string filter = null)

Queries types of ProductGroup.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsNkTypesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productGroups.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries types of ProductGroup.
                List&lt;ProductType&gt; result = apiInstance.TeamBuilderConfigsIdProductGroupsNkTypesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsNkTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productGroups. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductType>**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsnktypespost"></a>
# **TeamBuilderConfigsIdProductGroupsNkTypesPost**
> ProductType TeamBuilderConfigsIdProductGroupsNkTypesPost (string id, string nk, ProductType data = null)

Creates a new instance in types of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsNkTypesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productGroups.
            var data = new ProductType(); // ProductType |  (optional) 

            try
            {
                // Creates a new instance in types of this model.
                ProductType result = apiInstance.TeamBuilderConfigsIdProductGroupsNkTypesPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsNkTypesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productGroups. | 
 **data** | [**ProductType**](ProductType.md)|  | [optional] 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupspost"></a>
# **TeamBuilderConfigsIdProductGroupsPost**
> ProductGroup TeamBuilderConfigsIdProductGroupsPost (string id, ProductGroup data = null)

Creates a new instance in productGroups of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var data = new ProductGroup(); // ProductGroup |  (optional) 

            try
            {
                // Creates a new instance in productGroups of this model.
                ProductGroup result = apiInstance.TeamBuilderConfigsIdProductGroupsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **data** | [**ProductGroup**](ProductGroup.md)|  | [optional] 

### Return type

[**ProductGroup**](ProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsrelfkdelete"></a>
# **TeamBuilderConfigsIdProductGroupsRelFkDelete**
> void TeamBuilderConfigsIdProductGroupsRelFkDelete (string id, string fk)

Remove the productGroups relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productGroups

            try
            {
                // Remove the productGroups relation to an item by id.
                apiInstance.TeamBuilderConfigsIdProductGroupsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productGroups | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsrelfkhead"></a>
# **TeamBuilderConfigsIdProductGroupsRelFkHead**
> bool? TeamBuilderConfigsIdProductGroupsRelFkHead (string id, string fk)

Check the existence of productGroups relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productGroups

            try
            {
                // Check the existence of productGroups relation to an item by id.
                bool? result = apiInstance.TeamBuilderConfigsIdProductGroupsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productGroups | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductgroupsrelfkput"></a>
# **TeamBuilderConfigsIdProductGroupsRelFkPut**
> TeamBuilderConfigProductGroup TeamBuilderConfigsIdProductGroupsRelFkPut (string id, string fk, TeamBuilderConfigProductGroup data = null)

Add a related item by id for productGroups.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductGroupsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productGroups
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup |  (optional) 

            try
            {
                // Add a related item by id for productGroups.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigsIdProductGroupsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductGroupsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productGroups | 
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)|  | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialscountget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductSizeMaterialsCountGet (string id, string where = null)

Counts productSizeMaterials of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productSizeMaterials of TeamBuilderConfig.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsdelete"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsDelete**
> void TeamBuilderConfigsIdProductSizeMaterialsDelete (string id)

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
    public class TeamBuilderConfigsIdProductSizeMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id

            try
            {
                // Deletes all productSizeMaterials of this model.
                apiInstance.TeamBuilderConfigsIdProductSizeMaterialsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsfkdelete"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsFkDelete**
> void TeamBuilderConfigsIdProductSizeMaterialsFkDelete (string id, string fk)

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
    public class TeamBuilderConfigsIdProductSizeMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials

            try
            {
                // Delete a related item by id for productSizeMaterials.
                apiInstance.TeamBuilderConfigsIdProductSizeMaterialsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizeMaterials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsfkget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsFkGet**
> ProductSizeMaterial TeamBuilderConfigsIdProductSizeMaterialsFkGet (string id, string fk)

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
    public class TeamBuilderConfigsIdProductSizeMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials

            try
            {
                // Find a related item by id for productSizeMaterials.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizeMaterials | 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsfkput"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsFkPut**
> ProductSizeMaterial TeamBuilderConfigsIdProductSizeMaterialsFkPut (string id, string fk, ProductSizeMaterial data = null)

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
    public class TeamBuilderConfigsIdProductSizeMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Update a related item by id for productSizeMaterials.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
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

<a name="teambuilderconfigsidproductsizematerialsget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsGet**
> List<ProductSizeMaterial> TeamBuilderConfigsIdProductSizeMaterialsGet (string id, string filter = null)

Queries productSizeMaterials of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productSizeMaterials of TeamBuilderConfig.
                List&lt;ProductSizeMaterial&gt; result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductSizeMaterial>**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsnkmaterialget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsNkMaterialGet**
> ProductMaterial TeamBuilderConfigsIdProductSizeMaterialsNkMaterialGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation material.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsNkMaterialGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizeMaterials.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation material.
                ProductMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsNkMaterialGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsNkMaterialGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizeMaterials. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsnkpdfcolorprofileget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsNkPdfColorProfileGet**
> ProductPdfColorProfile TeamBuilderConfigsIdProductSizeMaterialsNkPdfColorProfileGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation pdfColorProfile.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsNkPdfColorProfileGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizeMaterials.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation pdfColorProfile.
                ProductPdfColorProfile result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsNkPdfColorProfileGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsNkPdfColorProfileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizeMaterials. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductPdfColorProfile**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsnksizeget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsNkSizeGet**
> ProductSize TeamBuilderConfigsIdProductSizeMaterialsNkSizeGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation size.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsNkSizeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizeMaterials.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation size.
                ProductSize result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsNkSizeGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsNkSizeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizeMaterials. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsnkteamget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsNkTeamGet**
> Team TeamBuilderConfigsIdProductSizeMaterialsNkTeamGet (string id, string nk, bool? refresh = null)

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
    public class TeamBuilderConfigsIdProductSizeMaterialsNkTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizeMaterials.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsNkTeamGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsNkTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizeMaterials. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialspost"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsPost**
> ProductSizeMaterial TeamBuilderConfigsIdProductSizeMaterialsPost (string id, ProductSizeMaterial data = null)

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
    public class TeamBuilderConfigsIdProductSizeMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Creates a new instance in productSizeMaterials of this model.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelcountget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductSizeMaterialsRelCountGet (string id, string where = null)

Counts productSizeMaterialsRel of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productSizeMaterialsRel of TeamBuilderConfig.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsreldelete"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelDelete**
> void TeamBuilderConfigsIdProductSizeMaterialsRelDelete (string id)

Deletes all productSizeMaterialsRel of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id

            try
            {
                // Deletes all productSizeMaterialsRel of this model.
                apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelfkdelete"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete**
> void TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete (string id, string fk)

Remove the productSizeMaterials relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials

            try
            {
                // Remove the productSizeMaterials relation to an item by id.
                apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizeMaterials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelfkdelete_0"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete_0**
> void TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete_0 (string id, string fk)

Delete a related item by id for productSizeMaterialsRel.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterialsRel

            try
            {
                // Delete a related item by id for productSizeMaterialsRel.
                apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete_0(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelFkDelete_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizeMaterialsRel | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelfkget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelFkGet**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigsIdProductSizeMaterialsRelFkGet (string id, string fk)

Find a related item by id for productSizeMaterialsRel.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterialsRel

            try
            {
                // Find a related item by id for productSizeMaterialsRel.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizeMaterialsRel | 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelfkhead"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelFkHead**
> bool? TeamBuilderConfigsIdProductSizeMaterialsRelFkHead (string id, string fk)

Check the existence of productSizeMaterials relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials

            try
            {
                // Check the existence of productSizeMaterials relation to an item by id.
                bool? result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizeMaterials | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelfkput"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelFkPut**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigsIdProductSizeMaterialsRelFkPut (string id, string fk, TeamBuilderConfigProductSizeMaterial data = null)

Add a related item by id for productSizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterials
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial |  (optional) 

            try
            {
                // Add a related item by id for productSizeMaterials.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizeMaterials | 
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)|  | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelfkput_0"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelFkPut_0**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigsIdProductSizeMaterialsRelFkPut_0 (string id, string fk, TeamBuilderConfigProductSizeMaterial data = null)

Update a related item by id for productSizeMaterialsRel.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelFkPut_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizeMaterialsRel
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial |  (optional) 

            try
            {
                // Update a related item by id for productSizeMaterialsRel.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelFkPut_0(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelFkPut_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizeMaterialsRel | 
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)|  | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelGet**
> List<TeamBuilderConfigProductSizeMaterial> TeamBuilderConfigsIdProductSizeMaterialsRelGet (string id, string filter = null)

Queries productSizeMaterialsRel of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productSizeMaterialsRel of TeamBuilderConfig.
                List&lt;TeamBuilderConfigProductSizeMaterial&gt; result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamBuilderConfigProductSizeMaterial>**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelnkbuilderconfigget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelNkBuilderConfigGet**
> TeamBuilderConfig TeamBuilderConfigsIdProductSizeMaterialsRelNkBuilderConfigGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation builderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelNkBuilderConfigGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizeMaterialsRel.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation builderConfig.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelNkBuilderConfigGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelNkBuilderConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizeMaterialsRel. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelnkpdfcolorprofileget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelNkPdfColorProfileGet**
> ProductPdfColorProfile TeamBuilderConfigsIdProductSizeMaterialsRelNkPdfColorProfileGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation pdfColorProfile.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelNkPdfColorProfileGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizeMaterialsRel.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation pdfColorProfile.
                ProductPdfColorProfile result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelNkPdfColorProfileGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelNkPdfColorProfileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizeMaterialsRel. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductPdfColorProfile**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelnkproductsizematerialget"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelNkProductSizeMaterialGet**
> ProductSizeMaterial TeamBuilderConfigsIdProductSizeMaterialsRelNkProductSizeMaterialGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation productSizeMaterial.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelNkProductSizeMaterialGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizeMaterialsRel.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation productSizeMaterial.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelNkProductSizeMaterialGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelNkProductSizeMaterialGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizeMaterialsRel. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizematerialsrelpost"></a>
# **TeamBuilderConfigsIdProductSizeMaterialsRelPost**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigsIdProductSizeMaterialsRelPost (string id, TeamBuilderConfigProductSizeMaterial data = null)

Creates a new instance in productSizeMaterialsRel of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizeMaterialsRelPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial |  (optional) 

            try
            {
                // Creates a new instance in productSizeMaterialsRel of this model.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizeMaterialsRelPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizeMaterialsRelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)|  | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizescountget"></a>
# **TeamBuilderConfigsIdProductSizesCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductSizesCountGet (string id, string where = null)

Counts productSizes of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productSizes of TeamBuilderConfig.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductSizesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesdelete"></a>
# **TeamBuilderConfigsIdProductSizesDelete**
> void TeamBuilderConfigsIdProductSizesDelete (string id)

Deletes all productSizes of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id

            try
            {
                // Deletes all productSizes of this model.
                apiInstance.TeamBuilderConfigsIdProductSizesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesfkdelete"></a>
# **TeamBuilderConfigsIdProductSizesFkDelete**
> void TeamBuilderConfigsIdProductSizesFkDelete (string id, string fk)

Delete a related item by id for productSizes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizes

            try
            {
                // Delete a related item by id for productSizes.
                apiInstance.TeamBuilderConfigsIdProductSizesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizes | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesfkget"></a>
# **TeamBuilderConfigsIdProductSizesFkGet**
> ProductSize TeamBuilderConfigsIdProductSizesFkGet (string id, string fk)

Find a related item by id for productSizes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizes

            try
            {
                // Find a related item by id for productSizes.
                ProductSize result = apiInstance.TeamBuilderConfigsIdProductSizesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizes | 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesfkput"></a>
# **TeamBuilderConfigsIdProductSizesFkPut**
> ProductSize TeamBuilderConfigsIdProductSizesFkPut (string id, string fk, ProductSize data = null)

Update a related item by id for productSizes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizes
            var data = new ProductSize(); // ProductSize |  (optional) 

            try
            {
                // Update a related item by id for productSizes.
                ProductSize result = apiInstance.TeamBuilderConfigsIdProductSizesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizes | 
 **data** | [**ProductSize**](ProductSize.md)|  | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesget"></a>
# **TeamBuilderConfigsIdProductSizesGet**
> List<ProductSize> TeamBuilderConfigsIdProductSizesGet (string id, string filter = null)

Queries productSizes of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productSizes of TeamBuilderConfig.
                List&lt;ProductSize&gt; result = apiInstance.TeamBuilderConfigsIdProductSizesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductSize>**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialscountget"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductSizesNkMaterialsCountGet (string id, string nk, string where = null)

Counts materials of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts materials of ProductSize.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialsdelete"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsDelete**
> void TeamBuilderConfigsIdProductSizesNkMaterialsDelete (string id, string nk)

Deletes all materials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.

            try
            {
                // Deletes all materials of this model.
                apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialsfkdelete"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsFkDelete**
> void TeamBuilderConfigsIdProductSizesNkMaterialsFkDelete (string id, string nk, string fk)

Delete a related item by id for materials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for materials

            try
            {
                // Delete a related item by id for materials.
                apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for materials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialsfkget"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsFkGet**
> ProductMaterial TeamBuilderConfigsIdProductSizesNkMaterialsFkGet (string id, string nk, string fk)

Find a related item by id for materials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for materials

            try
            {
                // Find a related item by id for materials.
                ProductMaterial result = apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for materials | 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialsfkput"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsFkPut**
> ProductMaterial TeamBuilderConfigsIdProductSizesNkMaterialsFkPut (string id, string nk, string fk, ProductMaterial data = null)

Update a related item by id for materials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for materials
            var data = new ProductMaterial(); // ProductMaterial |  (optional) 

            try
            {
                // Update a related item by id for materials.
                ProductMaterial result = apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for materials | 
 **data** | [**ProductMaterial**](ProductMaterial.md)|  | [optional] 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialsget"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsGet**
> List<ProductMaterial> TeamBuilderConfigsIdProductSizesNkMaterialsGet (string id, string nk, string filter = null)

Queries materials of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries materials of ProductSize.
                List&lt;ProductMaterial&gt; result = apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductMaterial>**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialspost"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsPost**
> ProductMaterial TeamBuilderConfigsIdProductSizesNkMaterialsPost (string id, string nk, ProductMaterial data = null)

Creates a new instance in materials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var data = new ProductMaterial(); // ProductMaterial |  (optional) 

            try
            {
                // Creates a new instance in materials of this model.
                ProductMaterial result = apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **data** | [**ProductMaterial**](ProductMaterial.md)|  | [optional] 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialsrelfkdelete"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsRelFkDelete**
> void TeamBuilderConfigsIdProductSizesNkMaterialsRelFkDelete (string id, string nk, string fk)

Remove the materials relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for materials

            try
            {
                // Remove the materials relation to an item by id.
                apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsRelFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for materials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialsrelfkhead"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsRelFkHead**
> bool? TeamBuilderConfigsIdProductSizesNkMaterialsRelFkHead (string id, string nk, string fk)

Check the existence of materials relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for materials

            try
            {
                // Check the existence of materials relation to an item by id.
                bool? result = apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsRelFkHead(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for materials | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkmaterialsrelfkput"></a>
# **TeamBuilderConfigsIdProductSizesNkMaterialsRelFkPut**
> ProductSizeMaterial TeamBuilderConfigsIdProductSizesNkMaterialsRelFkPut (string id, string nk, string fk, ProductSizeMaterial data = null)

Add a related item by id for materials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkMaterialsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for materials
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Add a related item by id for materials.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizesNkMaterialsRelFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkMaterialsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for materials | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkpdfcolorprofileget"></a>
# **TeamBuilderConfigsIdProductSizesNkPdfColorProfileGet**
> ProductPdfColorProfile TeamBuilderConfigsIdProductSizesNkPdfColorProfileGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation pdfColorProfile.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkPdfColorProfileGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation pdfColorProfile.
                ProductPdfColorProfile result = apiInstance.TeamBuilderConfigsIdProductSizesNkPdfColorProfileGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkPdfColorProfileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductPdfColorProfile**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkproductscountget"></a>
# **TeamBuilderConfigsIdProductSizesNkProductsCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductSizesNkProductsCountGet (string id, string nk, string where = null)

Counts products of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkProductsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts products of ProductSize.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductSizesNkProductsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkProductsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkproductsdelete"></a>
# **TeamBuilderConfigsIdProductSizesNkProductsDelete**
> void TeamBuilderConfigsIdProductSizesNkProductsDelete (string id, string nk)

Deletes all products of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkProductsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.

            try
            {
                // Deletes all products of this model.
                apiInstance.TeamBuilderConfigsIdProductSizesNkProductsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkProductsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkproductsfkdelete"></a>
# **TeamBuilderConfigsIdProductSizesNkProductsFkDelete**
> void TeamBuilderConfigsIdProductSizesNkProductsFkDelete (string id, string nk, string fk)

Delete a related item by id for products.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkProductsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for products

            try
            {
                // Delete a related item by id for products.
                apiInstance.TeamBuilderConfigsIdProductSizesNkProductsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkProductsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for products | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkproductsfkget"></a>
# **TeamBuilderConfigsIdProductSizesNkProductsFkGet**
> Product TeamBuilderConfigsIdProductSizesNkProductsFkGet (string id, string nk, string fk)

Find a related item by id for products.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkProductsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for products

            try
            {
                // Find a related item by id for products.
                Product result = apiInstance.TeamBuilderConfigsIdProductSizesNkProductsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkProductsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for products | 

### Return type

[**Product**](Product.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkproductsfkput"></a>
# **TeamBuilderConfigsIdProductSizesNkProductsFkPut**
> Product TeamBuilderConfigsIdProductSizesNkProductsFkPut (string id, string nk, string fk, Product data = null)

Update a related item by id for products.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkProductsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for products
            var data = new Product(); // Product |  (optional) 

            try
            {
                // Update a related item by id for products.
                Product result = apiInstance.TeamBuilderConfigsIdProductSizesNkProductsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkProductsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for products | 
 **data** | [**Product**](Product.md)|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkproductsget"></a>
# **TeamBuilderConfigsIdProductSizesNkProductsGet**
> List<Product> TeamBuilderConfigsIdProductSizesNkProductsGet (string id, string nk, string filter = null)

Queries products of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkProductsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries products of ProductSize.
                List&lt;Product&gt; result = apiInstance.TeamBuilderConfigsIdProductSizesNkProductsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkProductsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Product>**](Product.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnkproductspost"></a>
# **TeamBuilderConfigsIdProductSizesNkProductsPost**
> Product TeamBuilderConfigsIdProductSizesNkProductsPost (string id, string nk, Product data = null)

Creates a new instance in products of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkProductsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var data = new Product(); // Product |  (optional) 

            try
            {
                // Creates a new instance in products of this model.
                Product result = apiInstance.TeamBuilderConfigsIdProductSizesNkProductsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkProductsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **data** | [**Product**](Product.md)|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnksizematerialscountget"></a>
# **TeamBuilderConfigsIdProductSizesNkSizeMaterialsCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductSizesNkSizeMaterialsCountGet (string id, string nk, string where = null)

Counts sizeMaterials of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkSizeMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts sizeMaterials of ProductSize.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductSizesNkSizeMaterialsCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkSizeMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnksizematerialsdelete"></a>
# **TeamBuilderConfigsIdProductSizesNkSizeMaterialsDelete**
> void TeamBuilderConfigsIdProductSizesNkSizeMaterialsDelete (string id, string nk)

Deletes all sizeMaterials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkSizeMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.

            try
            {
                // Deletes all sizeMaterials of this model.
                apiInstance.TeamBuilderConfigsIdProductSizesNkSizeMaterialsDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkSizeMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnksizematerialsfkdelete"></a>
# **TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkDelete**
> void TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkDelete (string id, string nk, string fk)

Delete a related item by id for sizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for sizeMaterials

            try
            {
                // Delete a related item by id for sizeMaterials.
                apiInstance.TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for sizeMaterials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnksizematerialsfkget"></a>
# **TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkGet**
> ProductSizeMaterial TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkGet (string id, string nk, string fk)

Find a related item by id for sizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for sizeMaterials

            try
            {
                // Find a related item by id for sizeMaterials.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for sizeMaterials | 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnksizematerialsfkput"></a>
# **TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkPut**
> ProductSizeMaterial TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkPut (string id, string nk, string fk, ProductSizeMaterial data = null)

Update a related item by id for sizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var fk = fk_example;  // string | Foreign key for sizeMaterials
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Update a related item by id for sizeMaterials.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkSizeMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **fk** | **string**| Foreign key for sizeMaterials | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnksizematerialsget"></a>
# **TeamBuilderConfigsIdProductSizesNkSizeMaterialsGet**
> List<ProductSizeMaterial> TeamBuilderConfigsIdProductSizesNkSizeMaterialsGet (string id, string nk, string filter = null)

Queries sizeMaterials of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkSizeMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries sizeMaterials of ProductSize.
                List&lt;ProductSizeMaterial&gt; result = apiInstance.TeamBuilderConfigsIdProductSizesNkSizeMaterialsGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkSizeMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductSizeMaterial>**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnksizematerialspost"></a>
# **TeamBuilderConfigsIdProductSizesNkSizeMaterialsPost**
> ProductSizeMaterial TeamBuilderConfigsIdProductSizesNkSizeMaterialsPost (string id, string nk, ProductSizeMaterial data = null)

Creates a new instance in sizeMaterials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkSizeMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Creates a new instance in sizeMaterials of this model.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigsIdProductSizesNkSizeMaterialsPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkSizeMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesnktypeget"></a>
# **TeamBuilderConfigsIdProductSizesNkTypeGet**
> ProductType TeamBuilderConfigsIdProductSizesNkTypeGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation type.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesNkTypeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productSizes.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation type.
                ProductType result = apiInstance.TeamBuilderConfigsIdProductSizesNkTypeGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesNkTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productSizes. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizespost"></a>
# **TeamBuilderConfigsIdProductSizesPost**
> ProductSize TeamBuilderConfigsIdProductSizesPost (string id, ProductSize data = null)

Creates a new instance in productSizes of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var data = new ProductSize(); // ProductSize |  (optional) 

            try
            {
                // Creates a new instance in productSizes of this model.
                ProductSize result = apiInstance.TeamBuilderConfigsIdProductSizesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **data** | [**ProductSize**](ProductSize.md)|  | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesrelfkdelete"></a>
# **TeamBuilderConfigsIdProductSizesRelFkDelete**
> void TeamBuilderConfigsIdProductSizesRelFkDelete (string id, string fk)

Remove the productSizes relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizes

            try
            {
                // Remove the productSizes relation to an item by id.
                apiInstance.TeamBuilderConfigsIdProductSizesRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizes | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesrelfkhead"></a>
# **TeamBuilderConfigsIdProductSizesRelFkHead**
> bool? TeamBuilderConfigsIdProductSizesRelFkHead (string id, string fk)

Check the existence of productSizes relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizes

            try
            {
                // Check the existence of productSizes relation to an item by id.
                bool? result = apiInstance.TeamBuilderConfigsIdProductSizesRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizes | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproductsizesrelfkput"></a>
# **TeamBuilderConfigsIdProductSizesRelFkPut**
> TeamBuilderConfigProductSize TeamBuilderConfigsIdProductSizesRelFkPut (string id, string fk, TeamBuilderConfigProductSize data = null)

Add a related item by id for productSizes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductSizesRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productSizes
            var data = new TeamBuilderConfigProductSize(); // TeamBuilderConfigProductSize |  (optional) 

            try
            {
                // Add a related item by id for productSizes.
                TeamBuilderConfigProductSize result = apiInstance.TeamBuilderConfigsIdProductSizesRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductSizesRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productSizes | 
 **data** | [**TeamBuilderConfigProductSize**](TeamBuilderConfigProductSize.md)|  | [optional] 

### Return type

[**TeamBuilderConfigProductSize**](TeamBuilderConfigProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypescountget"></a>
# **TeamBuilderConfigsIdProductTypesCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductTypesCountGet (string id, string where = null)

Counts productTypes of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts productTypes of TeamBuilderConfig.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductTypesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesdelete"></a>
# **TeamBuilderConfigsIdProductTypesDelete**
> void TeamBuilderConfigsIdProductTypesDelete (string id)

Deletes all productTypes of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id

            try
            {
                // Deletes all productTypes of this model.
                apiInstance.TeamBuilderConfigsIdProductTypesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesfkdelete"></a>
# **TeamBuilderConfigsIdProductTypesFkDelete**
> void TeamBuilderConfigsIdProductTypesFkDelete (string id, string fk)

Delete a related item by id for productTypes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productTypes

            try
            {
                // Delete a related item by id for productTypes.
                apiInstance.TeamBuilderConfigsIdProductTypesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productTypes | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesfkget"></a>
# **TeamBuilderConfigsIdProductTypesFkGet**
> ProductType TeamBuilderConfigsIdProductTypesFkGet (string id, string fk)

Find a related item by id for productTypes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productTypes

            try
            {
                // Find a related item by id for productTypes.
                ProductType result = apiInstance.TeamBuilderConfigsIdProductTypesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productTypes | 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesfkput"></a>
# **TeamBuilderConfigsIdProductTypesFkPut**
> ProductType TeamBuilderConfigsIdProductTypesFkPut (string id, string fk, ProductType data = null)

Update a related item by id for productTypes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productTypes
            var data = new ProductType(); // ProductType |  (optional) 

            try
            {
                // Update a related item by id for productTypes.
                ProductType result = apiInstance.TeamBuilderConfigsIdProductTypesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productTypes | 
 **data** | [**ProductType**](ProductType.md)|  | [optional] 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesget"></a>
# **TeamBuilderConfigsIdProductTypesGet**
> List<ProductType> TeamBuilderConfigsIdProductTypesGet (string id, string filter = null)

Queries productTypes of TeamBuilderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries productTypes of TeamBuilderConfig.
                List&lt;ProductType&gt; result = apiInstance.TeamBuilderConfigsIdProductTypesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductType>**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesnkgroupget"></a>
# **TeamBuilderConfigsIdProductTypesNkGroupGet**
> ProductGroup TeamBuilderConfigsIdProductTypesNkGroupGet (string id, string nk, bool? refresh = null)

Fetches belongsTo relation group.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesNkGroupGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productTypes.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation group.
                ProductGroup result = apiInstance.TeamBuilderConfigsIdProductTypesNkGroupGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesNkGroupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productTypes. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductGroup**](ProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesnksizescountget"></a>
# **TeamBuilderConfigsIdProductTypesNkSizesCountGet**
> InlineResponse2001 TeamBuilderConfigsIdProductTypesNkSizesCountGet (string id, string nk, string where = null)

Counts sizes of ProductType.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesNkSizesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productTypes.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts sizes of ProductType.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdProductTypesNkSizesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesNkSizesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productTypes. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesnksizesdelete"></a>
# **TeamBuilderConfigsIdProductTypesNkSizesDelete**
> void TeamBuilderConfigsIdProductTypesNkSizesDelete (string id, string nk)

Deletes all sizes of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesNkSizesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productTypes.

            try
            {
                // Deletes all sizes of this model.
                apiInstance.TeamBuilderConfigsIdProductTypesNkSizesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesNkSizesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productTypes. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesnksizesfkdelete"></a>
# **TeamBuilderConfigsIdProductTypesNkSizesFkDelete**
> void TeamBuilderConfigsIdProductTypesNkSizesFkDelete (string id, string nk, string fk)

Delete a related item by id for sizes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesNkSizesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productTypes.
            var fk = fk_example;  // string | Foreign key for sizes

            try
            {
                // Delete a related item by id for sizes.
                apiInstance.TeamBuilderConfigsIdProductTypesNkSizesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesNkSizesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productTypes. | 
 **fk** | **string**| Foreign key for sizes | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesnksizesfkget"></a>
# **TeamBuilderConfigsIdProductTypesNkSizesFkGet**
> ProductSize TeamBuilderConfigsIdProductTypesNkSizesFkGet (string id, string nk, string fk)

Find a related item by id for sizes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesNkSizesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productTypes.
            var fk = fk_example;  // string | Foreign key for sizes

            try
            {
                // Find a related item by id for sizes.
                ProductSize result = apiInstance.TeamBuilderConfigsIdProductTypesNkSizesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesNkSizesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productTypes. | 
 **fk** | **string**| Foreign key for sizes | 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesnksizesfkput"></a>
# **TeamBuilderConfigsIdProductTypesNkSizesFkPut**
> ProductSize TeamBuilderConfigsIdProductTypesNkSizesFkPut (string id, string nk, string fk, ProductSize data = null)

Update a related item by id for sizes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesNkSizesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productTypes.
            var fk = fk_example;  // string | Foreign key for sizes
            var data = new ProductSize(); // ProductSize |  (optional) 

            try
            {
                // Update a related item by id for sizes.
                ProductSize result = apiInstance.TeamBuilderConfigsIdProductTypesNkSizesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesNkSizesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productTypes. | 
 **fk** | **string**| Foreign key for sizes | 
 **data** | [**ProductSize**](ProductSize.md)|  | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesnksizesget"></a>
# **TeamBuilderConfigsIdProductTypesNkSizesGet**
> List<ProductSize> TeamBuilderConfigsIdProductTypesNkSizesGet (string id, string nk, string filter = null)

Queries sizes of ProductType.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesNkSizesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productTypes.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries sizes of ProductType.
                List&lt;ProductSize&gt; result = apiInstance.TeamBuilderConfigsIdProductTypesNkSizesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesNkSizesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productTypes. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductSize>**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesnksizespost"></a>
# **TeamBuilderConfigsIdProductTypesNkSizesPost**
> ProductSize TeamBuilderConfigsIdProductTypesNkSizesPost (string id, string nk, ProductSize data = null)

Creates a new instance in sizes of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesNkSizesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var nk = nk_example;  // string | Foreign key for productTypes.
            var data = new ProductSize(); // ProductSize |  (optional) 

            try
            {
                // Creates a new instance in sizes of this model.
                ProductSize result = apiInstance.TeamBuilderConfigsIdProductTypesNkSizesPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesNkSizesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **nk** | **string**| Foreign key for productTypes. | 
 **data** | [**ProductSize**](ProductSize.md)|  | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypespost"></a>
# **TeamBuilderConfigsIdProductTypesPost**
> ProductType TeamBuilderConfigsIdProductTypesPost (string id, ProductType data = null)

Creates a new instance in productTypes of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var data = new ProductType(); // ProductType |  (optional) 

            try
            {
                // Creates a new instance in productTypes of this model.
                ProductType result = apiInstance.TeamBuilderConfigsIdProductTypesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **data** | [**ProductType**](ProductType.md)|  | [optional] 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesrelfkdelete"></a>
# **TeamBuilderConfigsIdProductTypesRelFkDelete**
> void TeamBuilderConfigsIdProductTypesRelFkDelete (string id, string fk)

Remove the productTypes relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productTypes

            try
            {
                // Remove the productTypes relation to an item by id.
                apiInstance.TeamBuilderConfigsIdProductTypesRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productTypes | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesrelfkhead"></a>
# **TeamBuilderConfigsIdProductTypesRelFkHead**
> bool? TeamBuilderConfigsIdProductTypesRelFkHead (string id, string fk)

Check the existence of productTypes relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productTypes

            try
            {
                // Check the existence of productTypes relation to an item by id.
                bool? result = apiInstance.TeamBuilderConfigsIdProductTypesRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productTypes | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidproducttypesrelfkput"></a>
# **TeamBuilderConfigsIdProductTypesRelFkPut**
> TeamBuilderConfigProductType TeamBuilderConfigsIdProductTypesRelFkPut (string id, string fk, TeamBuilderConfigProductType data = null)

Add a related item by id for productTypes.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigsIdProductTypesRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var fk = fk_example;  // string | Foreign key for productTypes
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType |  (optional) 

            try
            {
                // Add a related item by id for productTypes.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigsIdProductTypesRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdProductTypesRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **fk** | **string**| Foreign key for productTypes | 
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)|  | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidput"></a>
# **TeamBuilderConfigsIdPut**
> TeamBuilderConfig TeamBuilderConfigsIdPut (string id, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidreplacepost"></a>
# **TeamBuilderConfigsIdReplacePost**
> TeamBuilderConfig TeamBuilderConfigsIdReplacePost (string id, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidteamget"></a>
# **TeamBuilderConfigsIdTeamGet**
> Team TeamBuilderConfigsIdTeamGet (string id, bool? refresh = null)

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
    public class TeamBuilderConfigsIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamBuilderConfigsIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigspatch"></a>
# **TeamBuilderConfigsPatch**
> TeamBuilderConfig TeamBuilderConfigsPatch (TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigspost"></a>
# **TeamBuilderConfigsPost**
> TeamBuilderConfig TeamBuilderConfigsPost (TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsput"></a>
# **TeamBuilderConfigsPut**
> TeamBuilderConfig TeamBuilderConfigsPut (TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsreplaceorcreatepost"></a>
# **TeamBuilderConfigsReplaceOrCreatePost**
> TeamBuilderConfig TeamBuilderConfigsReplaceOrCreatePost (TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsupdatepost"></a>
# **TeamBuilderConfigsUpdatePost**
> InlineResponse2003 TeamBuilderConfigsUpdatePost (string where = null, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2003 result = apiInstance.TeamBuilderConfigsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsupsertwithwherepost"></a>
# **TeamBuilderConfigsUpsertWithWherePost**
> TeamBuilderConfig TeamBuilderConfigsUpsertWithWherePost (string where = null, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

