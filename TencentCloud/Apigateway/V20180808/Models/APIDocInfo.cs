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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class APIDocInfo : AbstractModel
    {
        
        /// <summary>
        /// API document ID
        /// </summary>
        [JsonProperty("ApiDocId")]
        public string ApiDocId{ get; set; }

        /// <summary>
        /// API document name
        /// </summary>
        [JsonProperty("ApiDocName")]
        public string ApiDocName{ get; set; }

        /// <summary>
        /// API document build status
        /// </summary>
        [JsonProperty("ApiDocStatus")]
        public string ApiDocStatus{ get; set; }

        /// <summary>
        /// Number of APIs with API documents
        /// </summary>
        [JsonProperty("ApiCount")]
        public long? ApiCount{ get; set; }

        /// <summary>
        /// Number of views of API document
        /// </summary>
        [JsonProperty("ViewCount")]
        public long? ViewCount{ get; set; }

        /// <summary>
        /// Number of releases of API document
        /// </summary>
        [JsonProperty("ReleaseCount")]
        public long? ReleaseCount{ get; set; }

        /// <summary>
        /// API document access URI
        /// </summary>
        [JsonProperty("ApiDocUri")]
        public string ApiDocUri{ get; set; }

        /// <summary>
        /// API document password for sharing
        /// </summary>
        [JsonProperty("SharePassword")]
        public string SharePassword{ get; set; }

        /// <summary>
        /// API document update time
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// Service ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Environment information
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// ID of the API for which to generate the API document
        /// </summary>
        [JsonProperty("ApiIds")]
        public string[] ApiIds{ get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Name of the API for which to generate the API document
        /// </summary>
        [JsonProperty("ApiNames")]
        public string[] ApiNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiDocId", this.ApiDocId);
            this.SetParamSimple(map, prefix + "ApiDocName", this.ApiDocName);
            this.SetParamSimple(map, prefix + "ApiDocStatus", this.ApiDocStatus);
            this.SetParamSimple(map, prefix + "ApiCount", this.ApiCount);
            this.SetParamSimple(map, prefix + "ViewCount", this.ViewCount);
            this.SetParamSimple(map, prefix + "ReleaseCount", this.ReleaseCount);
            this.SetParamSimple(map, prefix + "ApiDocUri", this.ApiDocUri);
            this.SetParamSimple(map, prefix + "SharePassword", this.SharePassword);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamArraySimple(map, prefix + "ApiIds.", this.ApiIds);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamArraySimple(map, prefix + "ApiNames.", this.ApiNames);
        }
    }
}

