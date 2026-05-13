/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaveDocRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// File name.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File type (md|txt|docx|pdf|xlsx).
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// The cos path of the platform, consistent with the UploadPath parameter queried by the DescribeStorageCredential api.
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// ETag, short for entity tag, is an information tag that identifies the content of an object when it is created and can be used to check whether the content of the object has changed.
        /// </summary>
        [JsonProperty("ETag")]
        public string ETag{ get; set; }

        /// <summary>
        /// Verify the consistency of the uploaded file on the cloud and the local file by validating the crc64 encoding in the cos_hash x-cos-hash-crc64ecma header.<br> After the COS is successfully uploaded, obtain it from the response header.
        /// </summary>
        [JsonProperty("CosHash")]
        public string CosHash{ get; set; }

        /// <summary>
        /// File size.
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// Applicable scope of labels: 1: all; 2: by conditional range.
        /// </summary>
        [JsonProperty("AttrRange")]
        public ulong? AttrRange{ get; set; }

        /// <summary>
        /// Source (0: source file import; 1: web page import).
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// Web page (or custom link) address.
        /// </summary>
        [JsonProperty("WebUrl")]
        public string WebUrl{ get; set; }

        /// <summary>
        /// Label reference.
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabelRefer[] AttrLabels{ get; set; }

        /// <summary>
        /// External reference link type: 0: system link; 1: custom link.
        /// When the value is 1, the weburl field cannot be empty; otherwise, it will not take effect.
        /// </summary>
        [JsonProperty("ReferUrlType")]
        public ulong? ReferUrlType{ get; set; }

        /// <summary>
        /// Effective start time, unix timestamp.
        /// </summary>
        [JsonProperty("ExpireStart")]
        public string ExpireStart{ get; set; }

        /// <summary>
        /// Effective end time, unix timestamp. 0 indicates permanent validity.
        /// </summary>
        [JsonProperty("ExpireEnd")]
        public string ExpireEnd{ get; set; }

        /// <summary>
        /// Whether to reference a link.
        /// </summary>
        [JsonProperty("IsRefer")]
        public bool? IsRefer{ get; set; }

        /// <summary>
        /// Document operation type: 1: batch import (import Q&A pairs in batches); 2: document import (normally import a single document). The default value is 1.<br>Please note that when opt = 1, please download the Excel template from the Tencent Cloud Agent Development Platform/ADP page.
        /// </summary>
        [JsonProperty("Opt")]
        public ulong? Opt{ get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// Downloadable or not. This parameter is only valid when `IsRefer` is **true** and `ReferUrlType` is 0.
        /// </summary>
        [JsonProperty("IsDownload")]
        public bool? IsDownload{ get; set; }

        /// <summary>
        /// Duplicate document processing method; match the first eligible method in sequence for processing.
        /// </summary>
        [JsonProperty("DuplicateFileHandles")]
        public DuplicateFileHandle[] DuplicateFileHandles{ get; set; }

        /// <summary>
        /// # Custom Splitting Rules
        /// The request parameter is a **JSON Object**. Refer to the API sample value for the specific format. It contains the following core fields:
        /// 
        /// | Field Name | Type | Description |
        /// |------------|------|-------------|
        /// | `xlsx_splitter` | Object | **Excel (xlsx) file splitting policy configuration**, valid only when processing Excel files |
        /// | `common_splitter` | Object | **General file splitting policy configuration** (for TXT, PDF and other files), supports splitting by page or by tag |
        /// | `table_style` | String | Output format of table content, e.g., HTML or Markdown |
        /// 
        /// ---
        /// 
        /// ## `xlsx_splitter` (Excel Splitting Policy)
        /// Used to configure the **splitting method for table files**.
        /// **Type: Object**
        /// ```json
        /// "xlsx_splitter": {
        ///   "header_interval": [1, 2],
        ///   "content_start": 10,
        ///   "split_row": 2
        /// }
        /// ```
        /// 
        /// ### Field Description
        /// | Field Name | Type | Description |
        /// |------------|------|-------------|
        /// | `header_interval` | Array\<Number\> | Row range of the table header, formatted as `[start row, end row]`. **Row numbers start from 1**. For example, `[1, 2]` means rows 1 to 2 are table headers. |
        /// | `content_start` | Number | **Start row number of table content (starting from 1)** |
        /// | `split_row` | Number | **Number of rows per split** |
        /// 
        /// ---
        /// 
        /// ## `common_splitter` (General File Splitting Policy)
        /// Used to configure the splitting method for **non-Excel files (TXT, PDF, DOCX, etc.)**. Two strategies are supported: **page-based splitting** or **identifier-based splitting**.
        /// **Type: Object**
        /// ```json
        /// "common_splitter": {
        ///   "splitter": "page",
        ///   "page_splitter": {
        ///     "chunk_length": 1000,
        ///     "chunk_overlap_length": 100
        ///   }
        /// }
        /// ```
        /// 
        /// ### Field Description
        /// | Field Name | Type | Description |
        /// |------------|------|-------------|
        /// | `splitter` | String | Splitting strategy type. Optional values: `"page"` (split by page), `"tag"` (split by identifier). |
        /// | `page_splitter` | Object | Configuration for **page-based splitting** |
        /// | `page_splitter.chunk_length` | Number | **Maximum chunk length** |
        /// | `page_splitter.chunk_overlap_length` | Number | **Chunk overlap length** |
        /// | `tag_splitter` | Object | Configuration for **custom splitting** |
        /// | `tag_splitter.tag` | Array\<String\> | **Splitting identifiers** |
        /// | `tag_splitter.chunk_length` | Number | **Maximum chunk length** |
        /// | `tag_splitter.chunk_overlap_length` | Number | **Chunk overlap length** |
        /// 
        /// ### Supplementary Notes
        /// - Valid values for the `splitter` field:
        ///   - `"page"`: Only page-based splitting is used; only configure fields under `page_splitter`.
        ///   - `"tag"`: Only identifier-based splitting (semicolon, line break, etc.) is used; only configure fields under `tag_splitter`.
        /// 
        /// ---
        /// 
        /// ## `table_style` (Table Output Style)
        /// Specifies the final return format of **table content extracted from Excel / CSV**, for front-end display and subsequent processing.
        /// **Type: String**
        /// ```json
        /// "table_style": "md"
        /// ```
        /// 
        /// ### Field Description
        /// | Field Name | Type | Description |
        /// |------------|------|-------------|
        /// | `table_style` | String | Specifies the output format of table content. Available values:<br> `"html"`: Return as HTML table, suitable for web page display.<br> `"md"`: Return as Markdown table syntax, suitable for documents and Markdown rendering environments. |
        /// </summary>
        [JsonProperty("SplitRule")]
        public string SplitRule{ get; set; }

        /// <summary>
        /// Document update frequency. Default value 0 means no update.
        /// </summary>
        [JsonProperty("UpdatePeriodInfo")]
        public UpdatePeriodInfo UpdatePeriodInfo{ get; set; }

        /// <summary>
        /// Document Effective Scope:
        /// 1 - Not effective;
        /// 2 - Effective only in development scope;
        /// 3 - Effective only in release scope;
        /// 4 - Effective in both development and release scopes.
        /// 
        /// Default value: The default knowledge base within the application is 2, and the shared knowledge base is 4.
        /// </summary>
        [JsonProperty("EnableScope")]
        public long? EnableScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "ETag", this.ETag);
            this.SetParamSimple(map, prefix + "CosHash", this.CosHash);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "WebUrl", this.WebUrl);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "ReferUrlType", this.ReferUrlType);
            this.SetParamSimple(map, prefix + "ExpireStart", this.ExpireStart);
            this.SetParamSimple(map, prefix + "ExpireEnd", this.ExpireEnd);
            this.SetParamSimple(map, prefix + "IsRefer", this.IsRefer);
            this.SetParamSimple(map, prefix + "Opt", this.Opt);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "IsDownload", this.IsDownload);
            this.SetParamArrayObj(map, prefix + "DuplicateFileHandles.", this.DuplicateFileHandles);
            this.SetParamSimple(map, prefix + "SplitRule", this.SplitRule);
            this.SetParamObj(map, prefix + "UpdatePeriodInfo.", this.UpdatePeriodInfo);
            this.SetParamSimple(map, prefix + "EnableScope", this.EnableScope);
        }
    }
}

