/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ModifyAPIDocRequest : AbstractModel
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
        /// Service name
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Environment name
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// List of APIs for which to generate documents
        /// </summary>
        [JsonProperty("ApiIds")]
        public string[] ApiIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiDocId", this.ApiDocId);
            this.SetParamSimple(map, prefix + "ApiDocName", this.ApiDocName);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamArraySimple(map, prefix + "ApiIds.", this.ApiIds);
        }
    }
}

