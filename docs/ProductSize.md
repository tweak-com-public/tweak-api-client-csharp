# TweakApi.Model.ProductSize
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Code** | **string** |  | 
**LegacyCode** | **string** |  | [optional] 
**Thumbnail** | [**CloudinaryImage**](CloudinaryImage.md) |  | [optional] 
**FoldingType** | **string** |  | [optional] 
**FoldingMethod** | **string** |  | [optional] 
**BindingType** | **string** |  | [optional] 
**DoubleSided** | **bool?** |  | [optional] [default to false]
**DieCut** | **bool?** |  | [optional] [default to false]
**UnfoldedSize** | [**Dimensions**](Dimensions.md) |  | [optional] 
**FoldedSize** | [**Dimensions**](Dimensions.md) |  | [optional] 
**PdfSize** | [**Dimensions**](Dimensions.md) |  | [optional] 
**PdfPageCount** | **double?** |  | [optional] [default to 1.0]
**PdfDpi** | **double?** |  | [optional] [default to 300.0]
**PdfOutputScale** | **double?** |  | [optional] [default to 100.0]
**PrintProfile** | **string** |  | [optional] 
**CustomerSize** | [**Dimensions**](Dimensions.md) |  | [optional] 
**CustomerPageCount** | **double?** |  | [optional] [default to 1.0]
**MaxBleed** | [**Bounds**](Bounds.md) |  | [optional] 
**DefaultBleed** | [**Bounds**](Bounds.md) |  | [optional] 
**SafeArea** | [**Bounds**](Bounds.md) |  | [optional] 
**Unit** | **string** |  | [optional] 
**Frame** | **double?** |  | [optional] [default to 0.0]
**Shape** | **string** |  | [optional] 
**Orientation** | **string** |  | [optional] 
**Format** | **string** |  | 
**EnvelopeWindow** | **string** |  | [optional] 
**CanvasImageCount** | **double?** |  | [optional] [default to 0.0]
**Options** | **string** |  | [optional] [default to "none"]
**DisplayType** | **string** |  | [optional] [default to "none"]
**Created** | **DateTime?** |  | [optional] 
**Modified** | **DateTime?** |  | [optional] 
**Id** | **string** |  | [optional] 
**PdfColorProfileId** | **string** |  | [optional] 
**TypeId** | **string** |  | [optional] 
**Type** | [**ProductType**](ProductType.md) |  | [optional] 
**Materials** | [**List&lt;ProductMaterial&gt;**](ProductMaterial.md) |  | [optional] 
**SizeMaterials** | [**List&lt;ProductSizeMaterial&gt;**](ProductSizeMaterial.md) |  | [optional] 
**Products** | [**List&lt;Product&gt;**](Product.md) |  | [optional] 
**PdfColorProfile** | [**ProductPdfColorProfile**](ProductPdfColorProfile.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

