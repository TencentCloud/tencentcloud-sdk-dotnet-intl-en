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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class APIResource : AbstractModel
    {
        
        /// <summary>
        /// Specifies the resource ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Specifies the resource name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Specifies the API service ID list associated with the API resource.
        /// </summary>
        [JsonProperty("APIServiceIds")]
        public string[] APIServiceIds{ get; set; }

        /// <summary>
        /// Specifies the resource path.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Request method list. valid values: GET, POST, PUT, HEAD, PATCH, OPTIONS, DELETE.
        /// </summary>
        [JsonProperty("Methods")]
        public string[] Methods{ get; set; }

        /// <summary>
        /// Specifies the specific content of the request content match rule, which must comply with the expression grammar. please refer to the product document for detailed requirements.
        /// </summary>
        [JsonProperty("RequestConstraint")]
        public string RequestConstraint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "APIServiceIds.", this.APIServiceIds);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamArraySimple(map, prefix + "Methods.", this.Methods);
            this.SetParamSimple(map, prefix + "RequestConstraint", this.RequestConstraint);
        }
    }
}

