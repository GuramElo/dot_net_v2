﻿using Reddit.Dtos;
using Reddit.Models;
using Riok.Mapperly.Abstractions;

namespace Reddit.Mapper
{
    [Mapper]
    public partial class Mapper : IMapper
    {
        public partial Community toCommunity(CreateCommunityDto createCommunityDto);

        public partial Post toPost(CreatePostDto createPostDto);
    }
}
