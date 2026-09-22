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

    public class ApplyUploadRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Media type. For available values, see <a href="https://www.tencentcloud.com/document/product/266/9760?from_cn_redirect=1#.E6.96.87.E4.BB.B6.E7.B1.BB.E5.9E.8B">upload capability summary</a>.</p>
        /// </summary>
        [JsonProperty("MediaType")]
        public string MediaType{ get; set; }

        /// <summary>
        /// <p><b>Video-on-Demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate VOD services on or after December 25, 2023, this field must be set to the application ID when accessing resources in VOD applications, whether the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Media name.</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>Cover Type. For available values, see <a href="https://www.tencentcloud.com/document/product/266/9760?from_cn_redirect=1#.E6.96.87.E4.BB.B6.E7.B1.BB.E5.9E.8B">upload capability summary</a>.</p>
        /// </summary>
        [JsonProperty("CoverType")]
        public string CoverType{ get; set; }

        /// <summary>
        /// <p>Subsequent media task processing operations, i.e., automatic task initiation after media upload is completed. The parameter value is the task flow template name. VOD supports <a href="https://www.tencentcloud.com/document/product/266/33819?from_cn_redirect=1">creating a task flow template</a> and naming the template.</p>
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// <p>Media file expiry time, format according to the ISO 8601 standard representation. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Specify the upload park. This is applicable only to the user with special requirements for the upload target region.</p>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category and obtain the category ID through the <a href="https://www.tencentcloud.com/document/product/266/7812?from_cn_redirect=1">Create Category</a> API.</p><li>Default value: 0, indicating other categories.</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The <a href="https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1">upload completion callback</a> returns the value of this field. The maximum length is 250 characters.</p>
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// <p>Session context. This is used to pass user request information. When the Procedure parameter is specified, the <a href="https://www.tencentcloud.com/document/product/266/9636?from_cn_redirect=1">task flow status change callback</a> returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Reserved field, used for special purposes.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "CoverType", this.CoverType);
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "MediaStoragePath", this.MediaStoragePath);
        }
    }
}

