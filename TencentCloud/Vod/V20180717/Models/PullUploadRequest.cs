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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PullUploadRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Media URL to be pulled. Temporary not support pull in Dash format (support HLS).<br>For supported extensions, see <a href="https://www.tencentcloud.com/document/product/266/9760?from_cn_redirect=1#.E5.AA.92.E4.BD.93.E7.B1.BB.E5.9E.8B">Media Type</a>. Please ensure the media URL can access.</p>
        /// </summary>
        [JsonProperty("MediaUrl")]
        public string MediaUrl{ get; set; }

        /// <summary>
        /// <p>Media type (extension). For supported types, see <a href="https://www.tencentcloud.com/document/product/266/9760?from_cn_redirect=1#.E5.AA.92.E4.BD.93.E7.B1.BB.E5.9E.8B">Media Type</a>.<br>If MediaType is not specified or is an empty string, the file type is automatically obtained based on MediaUrl.</p>
        /// </summary>
        [JsonProperty("MediaType")]
        public string MediaType{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574">application</a> ID. For customers who activate VOD services from December 25, 2023, if they access resources in VOD applications (whether the default application or a newly created application), they must fill in this field with the app ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Media name.</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>Video cover URL to fetch. Supported file formats: gif, jpeg (jpg), png.</p>
        /// </summary>
        [JsonProperty("CoverUrl")]
        public string CoverUrl{ get; set; }

        /// <summary>
        /// <p>For media subsequent task operation, see <a href="https://www.tencentcloud.com/document/product/266/9759?from_cn_redirect=1">Upload specified task flow</a>.</p>
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// <p>Media file expiry time, format according to the ISO 8601 standard representation. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Designated upload park, applicable only to users with special requirements for upload region:</p><li>If not specified, upload to your [default region](https://www.tencentcloud.com/document/product/266/14059?from=11329?from_cn_redirect=1#.E5.AD.98.E5.82.A8.E5.9C.B0.E5.9F.9F.E6.AD.A5.E9.AA.A4) by default.</li><li>If a designated upload park is specified, please confirm that the corresponding storage regions have been enabled in [upload storage settings](https://www.tencentcloud.com/document/product/266/14059?from=11329?from_cn_redirect=1#.E5.AD.98.E5.82.A8.E5.9C.B0.E5.9F.9F.E6.AD.A5.E9.AA.A4).</li>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category through the <a href="https://www.tencentcloud.com/document/product/266/31772?from_cn_redirect=1">Create Category</a> API to obtain the category ID.</p>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If this is not specified, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. When a Procedure task is specified, the task flow status change callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Reserved field, used for special purposes.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The <a href="/document/product/266/7830">upload completion callback</a> returns the value of this field. The maximum length is 250 characters.</p>
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// <p>Media storage path, starting with /.<br>Only sub-apps in <a href="https://www.tencentcloud.com/document/product/266/126825?from_cn_redirect=1">FileID + Path mode</a> can specify a storage path.</p>
        /// </summary>
        [JsonProperty("MediaStoragePath")]
        public string MediaStoragePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaUrl", this.MediaUrl);
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "CoverUrl", this.CoverUrl);
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
            this.SetParamSimple(map, prefix + "MediaStoragePath", this.MediaStoragePath);
        }
    }
}

