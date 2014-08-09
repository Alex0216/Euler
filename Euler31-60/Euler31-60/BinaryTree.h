#pragma once

#include <string>
#include <memory>

class BinaryTree
{
    struct Node
    {
        std::unique_ptr<Node> Left;
        std::unique_ptr<Node> Right;
        int Value;
    };

    public:
        BinaryTree();
        ~BinaryTree();

        std::unique_ptr<Node> Head;

        void PrintTree() const;

};

