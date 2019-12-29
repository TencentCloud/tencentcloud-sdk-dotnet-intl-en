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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoScalingGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group name, which can only contain letters, numbers, underscores, hyphens ("-"), and decimal points with a maximum length of 55 bytes and must be unique under your account.
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// Launch configuration ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Maximum number of instances. Value range: 0-2,000.
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// Minimum number of instances. Value range: 0-2,000.
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// VPC ID; if on a basic network, enter an empty string
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Default cooldown period in seconds. Default value: 300
        /// </summary>
        [JsonProperty("DefaultCooldown")]
        public ulong? DefaultCooldown{ get; set; }

        /// <summary>
        /// Desired number of instances. The number should be no larger than the maximum and no smaller than minimum number of instances
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// List of classic CLB IDs. Currently, the maximum length is 20. You cannot specify LoadBalancerIds and ForwardLoadBalancers at the same time.
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// List of CLBs. Currently, the maximum length is 20. You cannot specify LoadBalancerIds and ForwardLoadBalancers at the same time.
        /// </summary>
        [JsonProperty("ForwardLoadBalancers")]
        public ForwardLoadBalancer[] ForwardLoadBalancers{ get; set; }

        /// <summary>
        /// List of subnet IDs. A subnet must be specified in the VPC scenario. If multiple subnets are entered, their priority will be determined by the order in which they are entered, and they will be tried one by one until instances can be successfully created.
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// Termination policy. Currently, the maximum length is 1. Value range: OLDEST_INSTANCE, NEWEST_INSTANCE. Default value: OLDEST_INSTANCE.
        /// <br><li> OLDEST_INSTANCE: The oldest instance in the auto scaling group will be terminated first.
        /// <br><li> NEWEST_INSTANCE: The newest instance in the auto scaling group will be terminated first.
        /// </summary>
        [JsonProperty("TerminationPolicies")]
        public string[] TerminationPolicies{ get; set; }

        /// <summary>
        /// List of availability zones. An availability zone must be specified in the basic network scenario. If multiple availability zones are entered, their priority will be determined by the order in which they are entered, and they will be tried one by one until instances can be successfully created.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Retry policy. Value range: IMMEDIATE_RETRY, INCREMENTAL_INTERVALS, and NO_RETRY. Default value: IMMEDIATE_RETRY.
        /// <br><li> IMMEDIATE_RETRY: Retrying immediately in a short period of time and stopping after a number of consecutive failures (5).
        /// <br><li> INCREMENTAL_INTERVALS: Retrying at incremental intervals, i.e., as the number of consecutive failures increases, the retry interval gradually increases, ranging from one second to one day.
        /// <br><li> NO_RETRY: No retry until a user call or alarm message is received again.
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public string RetryPolicy{ get; set; }

        /// <summary>
        /// Availability zone verification policy. Value range: ALL, ANY. Default value: ANY.
        /// <br><li> ALL: The verification will succeed only if all availability zones (Zone) or subnets (SubnetId) are available; otherwise, an error will be reported.
        /// <br><li> ANY: The verification will success if any availability zone (Zone) or subnet (SubnetId) is available; otherwise, an error will be reported.
        /// 
        /// Common reasons why an availability zone or subnet is unavailable include stock-out of CVM instances or CBS cloud disks in the availability zone, insufficient quota in the availability zone, or insufficient IPs in the subnet.
        /// If an availability zone or subnet in Zones/SubnetIds does not exist, a verification error will be reported regardless of the value of ZonesCheckPolicy.
        /// </summary>
        [JsonProperty("ZonesCheckPolicy")]
        public string ZonesCheckPolicy{ get; set; }

        /// <summary>
        /// List of tag descriptions. This parameter is used to bind a tag to an auto scaling group as well as the corresponding resource instances.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Service settings such as unhealthy instance replacement.
        /// </summary>
        [JsonProperty("ServiceSettings")]
        public ServiceSettings ServiceSettings{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DefaultCooldown", this.DefaultCooldown);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "ForwardLoadBalancers.", this.ForwardLoadBalancers);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "TerminationPolicies.", this.TerminationPolicies);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "RetryPolicy", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "ZonesCheckPolicy", this.ZonesCheckPolicy);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ServiceSettings.", this.ServiceSettings);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
        }
    }
}

