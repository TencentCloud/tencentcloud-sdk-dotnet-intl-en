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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeConditionsTemplateListRequest : AbstractModel
    {
        
        /// <summary>
        /// The value is fixed to `monitor`.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// View name, which can be obtained via [DescribeAllNamespaces](https://intl.cloud.tencent.com/document/product/248/48683?from_cn_redirect=1). For the monitoring of Tencent Cloud services, the value of this parameter is `QceNamespacesNew.N.Id` of the output parameter of `DescribeAllNamespaces`, for example, `cvm_device`.
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// Filter by trigger condition template name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Filter by trigger condition template ID.
        /// </summary>
        [JsonProperty("GroupID")]
        public string GroupID{ get; set; }

        /// <summary>
        /// Pagination parameter, which specifies the number of returned results per page. Value range: 1-100. Default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Pagination offset starting from 0. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Sorting method by update time. `asc`: Ascending order; `desc`: Descending order.
        /// </summary>
        [JsonProperty("UpdateTimeOrder")]
        public string UpdateTimeOrder{ get; set; }

        /// <summary>
        /// Sorting order based on the number of associated policies. Valid values: `asc` (ascending order), `desc` (descending order).
        /// </summary>
        [JsonProperty("PolicyCountOrder")]
        public string PolicyCountOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupID", this.GroupID);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "UpdateTimeOrder", this.UpdateTimeOrder);
            this.SetParamSimple(map, prefix + "PolicyCountOrder", this.PolicyCountOrder);
        }
    }
}

