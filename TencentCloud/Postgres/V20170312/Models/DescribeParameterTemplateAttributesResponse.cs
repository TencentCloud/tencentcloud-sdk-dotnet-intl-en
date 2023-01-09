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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeParameterTemplateAttributesResponse : AbstractModel
    {
        
        /// <summary>
        /// Parameter template ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Number of parameters contained in the parameter template
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Parameter information contained in the parameter template
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ParamInfoSet")]
        public ParamInfo[] ParamInfoSet{ get; set; }

        /// <summary>
        /// Parameter template name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Database version applicable to a parameter template
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }

        /// <summary>
        /// Database engine applicable to a parameter template
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBEngine")]
        public string DBEngine{ get; set; }

        /// <summary>
        /// Parameter template description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TemplateDescription")]
        public string TemplateDescription{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "ParamInfoSet.", this.ParamInfoSet);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
            this.SetParamSimple(map, prefix + "DBEngine", this.DBEngine);
            this.SetParamSimple(map, prefix + "TemplateDescription", this.TemplateDescription);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

