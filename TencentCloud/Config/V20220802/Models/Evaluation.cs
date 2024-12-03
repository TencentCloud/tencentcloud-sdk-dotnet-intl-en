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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Evaluation : AbstractModel
    {
        
        /// <summary>
        /// Evaluated resource id. It can contain 0 to 256 characters.
        /// </summary>
        [JsonProperty("ComplianceResourceId")]
        public string ComplianceResourceId{ get; set; }

        /// <summary>
        /// Evaluated resource type.
        /// Supported:
        /// QCS::CVM::Instance、 QCS::CBS::Disk、QCS::VPC::Vpc、QCS::VPC::Subnet、QCS::VPC::SecurityGroup、 QCS::CAM::User、QCS::CAM::Group、QCS::CAM::Policy、QCS::CAM::Role、QCS::COS::Bucket
        /// </summary>
        [JsonProperty("ComplianceResourceType")]
        public string ComplianceResourceType{ get; set; }

        /// <summary>
        /// Evaluated resource region.
        /// It can contain 0 to 32 characters.
        /// </summary>
        [JsonProperty("ComplianceRegion")]
        public string ComplianceRegion{ get; set; }

        /// <summary>
        /// Compliance type. Valid values:
        /// COMPLIANT: Compliant,
        /// NON_COMPLIANT: Non-compliant
        /// </summary>
        [JsonProperty("ComplianceType")]
        public string ComplianceType{ get; set; }

        /// <summary>
        /// Supplementary information for non-compliant resources.
        /// </summary>
        [JsonProperty("Annotation")]
        public Annotation Annotation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComplianceResourceId", this.ComplianceResourceId);
            this.SetParamSimple(map, prefix + "ComplianceResourceType", this.ComplianceResourceType);
            this.SetParamSimple(map, prefix + "ComplianceRegion", this.ComplianceRegion);
            this.SetParamSimple(map, prefix + "ComplianceType", this.ComplianceType);
            this.SetParamObj(map, prefix + "Annotation.", this.Annotation);
        }
    }
}

