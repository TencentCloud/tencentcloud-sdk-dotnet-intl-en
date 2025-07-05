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

    public class DescribeApiResultServiceParametersInfo : AbstractModel
    {
        
        /// <summary>
        /// API backend service parameter name. This is only applicable when `ServiceType` is `HTTP`. Names of frontend and backend parameters can be different. 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Location of the API backend service parameter, such as `head` This is only applicable when `ServiceType` is `HTTP`. Configurations of frontend and backend parameters can be different. 
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// Location of the frontend parameter corresponding to the API backend service parameter, such as `head` This is only applicable when `ServiceType` is `HTTP`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RelevantRequestParameterPosition")]
        public string RelevantRequestParameterPosition{ get; set; }

        /// <summary>
        /// Name of the frontend parameter corresponding to the API backend service parameter. This is only applicable when `ServiceType` is `HTTP`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RelevantRequestParameterName")]
        public string RelevantRequestParameterName{ get; set; }

        /// <summary>
        /// Default value of API backend service parameter. This is only applicable when `ServiceType` is `HTTP`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// Description of API backend service parameter. This is only applicable when `ServiceType` is `HTTP`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RelevantRequestParameterDesc")]
        public string RelevantRequestParameterDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "RelevantRequestParameterPosition", this.RelevantRequestParameterPosition);
            this.SetParamSimple(map, prefix + "RelevantRequestParameterName", this.RelevantRequestParameterName);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "RelevantRequestParameterDesc", this.RelevantRequestParameterDesc);
        }
    }
}

