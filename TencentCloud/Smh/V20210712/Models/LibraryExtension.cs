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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LibraryExtension : AbstractModel
    {
        
        /// <summary>
        /// Specifies whether it is a file type media library that can store any type of file (true) or a media type media library that can only store images and playable video types (false). defaults to false. cannot be modified once created.
        /// </summary>
        [JsonProperty("IsFileLibrary")]
        public bool? IsFileLibrary{ get; set; }

        /// <summary>
        /// true indicates a multi-tenant space media library, allowing the creation of multiple tenant spaces. false indicates a single-tenant space media library, where tenant spaces cannot be created and only the default single tenant space can be used. defaults to false. cannot be modified after the media library is created.
        /// </summary>
        [JsonProperty("IsMultiSpace")]
        public bool? IsMultiSpace{ get; set; }

        /// <summary>
        /// Specifies the storage type for files saved to cloud object storage. valid values: STANDARD, STANDARD_IA, INTELLIGENT_TIERING, MAZ_STANDARD, MAZ_STANDARD_IA, and MAZ_INTELLIGENT_TIERING. defaults to STANDARD. when using a multi-AZ bucket, MAZ_ prefixed storage types for multi-AZ are automatically used, otherwise non-MAZ_ prefixed storage types for non-multi-AZ are used. when specifying INTELLIGENT TIERING storage INTELLIGENT_TIERING or MAZ_INTELLIGENT_TIERING, the bucket must have INTELLIGENT TIERING storage enabled beforehand, otherwise failure will be returned. cannot be modified after the media library is created.
        /// </summary>
        [JsonProperty("CosStorageClass")]
        public string CosStorageClass{ get; set; }

        /// <summary>
        /// Specifies whether the recycle bin feature is enabled. defaults to false.
        /// </summary>
        [JsonProperty("UseRecycleBin")]
        public bool? UseRecycleBin{ get; set; }

        /// <summary>
        /// Specifies the number of days to automatically delete items in the recycle bin when enabled, must not exceed 1095 (3 years). a value of 0 indicates no automatic deletion, defaults to 0. this property is null when the recycle bin is not enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoRemoveRecycledDays")]
        public ulong? AutoRemoveRecycledDays{ get; set; }

        /// <summary>
        /// Whether to enable the file path search feature. is false by default.
        /// </summary>
        [JsonProperty("EnableSearch")]
        public bool? EnableSearch{ get; set; }

        /// <summary>
        /// Specifies whether to deny the configuration request when setting the space quota for a media library or tenant and the quota is less than the used storage capacity. is false by default.
        /// </summary>
        [JsonProperty("DenyOnQuotaLessThanUsage")]
        public bool? DenyOnQuotaLessThanUsage{ get; set; }

        /// <summary>
        /// Specifies whether the earlier version is enabled. defaults to false.
        /// </summary>
        [JsonProperty("EnableFileHistory")]
        public bool? EnableFileHistory{ get; set; }

        /// <summary>
        /// Specifies the maximum number of historical versions to retain for a single file when versioning is enabled, with a value range of 1 to 999. this property may be null when versioning is not enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileHistoryCount")]
        public ulong? FileHistoryCount{ get; set; }

        /// <summary>
        /// Specifies the maximum days to retain earlier versions when versioning is enabled, with a value range of 0 to 999. when set to 0, it represents permanent retention. this property may be null when versioning is not enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileHistoryExpireDay")]
        public ulong? FileHistoryExpireDay{ get; set; }

        /// <summary>
        /// The maximum length of a directory or file name must not exceed 255, with a default value of 255. modifying this parameter will not affect existing directories or file names. if the value of this field is decreased, the length of existing directories or file names exceeding the target value does not change.
        /// </summary>
        [JsonProperty("MaxDirFileNameLength")]
        public ulong? MaxDirFileNameLength{ get; set; }

        /// <summary>
        /// Whether public read is enabled. once enabled, read operations require no access token. it is false by default. this property is supported only in single-tenant space media libraries. otherwise, it is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsPublicRead")]
        public bool? IsPublicRead{ get; set; }

        /// <summary>
        /// Specifies whether the multi-album feature is enabled for the media type media library. once enabled, first-level directories (albums) can be created, and media files can only be saved in these albums. unless enabled, albums cannot be created, and media files can only be saved in the root directory. defaults to false. this property is only supported for single-tenant space media type media libraries, otherwise it is null. cannot be modified after the media library is created.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsMultiAlbum")]
        public bool? IsMultiAlbum{ get; set; }

        /// <summary>
        /// Specifies whether the media library of the media type allows image uploads, set to true by default. this property is supported only for the media library of the media type in a single tenant space, otherwise it is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AllowPhoto")]
        public bool? AllowPhoto{ get; set; }

        /// <summary>
        /// Specifies the allowed extensions when the media type media library allows photo uploads. empty array by default. at this point, it will automatically determine based on the MIME type corresponding to the file extension. this property is supported only for single-tenant space media type media libraries. otherwise, the property is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AllowPhotoExtName")]
        public string[] AllowPhotoExtName{ get; set; }

        /// <summary>
        /// Media type media library specifies whether video upload is allowed, set to true by default. this property is supported only in single tenant space media type media library, otherwise the property is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AllowVideo")]
        public bool? AllowVideo{ get; set; }

        /// <summary>
        /// Specifies the allowed extensions when the media type media library permits video uploads. the default is an empty array, at which point it will automatically determine based on the MIME type corresponding to the file extension. this property is supported only for single-tenant space media type media libraries, otherwise it is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AllowVideoExtName")]
        public string[] AllowVideoExtName{ get; set; }

        /// <summary>
        /// Specifies the file extensions allowed in the file type media library, empty by default. at this point, all types of files are upload allowed. this property is supported only for the file type media library in a single tenant space, otherwise it is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AllowFileExtName")]
        public string[] AllowFileExtName{ get; set; }

        /// <summary>
        /// Specifies whether to perform sensitive content identification during image upload. the value is false by default. this property is supported only in the single-tenant space media library, otherwise it is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecognizeSensitiveContent")]
        public bool? RecognizeSensitiveContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsFileLibrary", this.IsFileLibrary);
            this.SetParamSimple(map, prefix + "IsMultiSpace", this.IsMultiSpace);
            this.SetParamSimple(map, prefix + "CosStorageClass", this.CosStorageClass);
            this.SetParamSimple(map, prefix + "UseRecycleBin", this.UseRecycleBin);
            this.SetParamSimple(map, prefix + "AutoRemoveRecycledDays", this.AutoRemoveRecycledDays);
            this.SetParamSimple(map, prefix + "EnableSearch", this.EnableSearch);
            this.SetParamSimple(map, prefix + "DenyOnQuotaLessThanUsage", this.DenyOnQuotaLessThanUsage);
            this.SetParamSimple(map, prefix + "EnableFileHistory", this.EnableFileHistory);
            this.SetParamSimple(map, prefix + "FileHistoryCount", this.FileHistoryCount);
            this.SetParamSimple(map, prefix + "FileHistoryExpireDay", this.FileHistoryExpireDay);
            this.SetParamSimple(map, prefix + "MaxDirFileNameLength", this.MaxDirFileNameLength);
            this.SetParamSimple(map, prefix + "IsPublicRead", this.IsPublicRead);
            this.SetParamSimple(map, prefix + "IsMultiAlbum", this.IsMultiAlbum);
            this.SetParamSimple(map, prefix + "AllowPhoto", this.AllowPhoto);
            this.SetParamArraySimple(map, prefix + "AllowPhotoExtName.", this.AllowPhotoExtName);
            this.SetParamSimple(map, prefix + "AllowVideo", this.AllowVideo);
            this.SetParamArraySimple(map, prefix + "AllowVideoExtName.", this.AllowVideoExtName);
            this.SetParamArraySimple(map, prefix + "AllowFileExtName.", this.AllowFileExtName);
            this.SetParamSimple(map, prefix + "RecognizeSensitiveContent", this.RecognizeSensitiveContent);
        }
    }
}

